using bean;
using services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Update
{
    public partial class UpdateExigence : Form
    {
        int id_exigence;
        Exigence exigence;
        string caption;
        string message;

        public UpdateExigence(int id_exigence)
        {
            InitializeComponent();
            this.id_exigence = id_exigence;
        }

        private void UpdateExigence_Load(object sender, EventArgs e)
        {
            // On récupere l'exigence à modifier
            exigence = FactoryService.CreateServiceExigence().GetExigenceById(id_exigence);
            // On rempli le formulaire de modification
            TBDescription.Text = exigence.Decription;
            TBIdentifiantExigence.Text = exigence.Identifiant;

            CBTypeExigences.Items.Clear();
            CBTypeExigences.DisplayMember = "Text";
            CBTypeExigences.ValueMember = "Value";
            int cpt = 0;
            foreach (TypeExigence type in FactoryService.CreateServiceTypeExigence().GetAllTypeExigences())
            {
                CBTypeExigences.Items.Add(new { Text = type.Label, Value = type.Id });
                if (type.Id == exigence.Type)
                    CBTypeExigences.SelectedIndex = cpt;
                cpt++;
            }

        }

        private void BtnUpdateExigence_Click(object sender, EventArgs e)
        {
            // On verifieque tous les champs on été saisis
            if (TBDescription.Text == "" || TBIdentifiantExigence.Text == "" || CBTypeExigences.SelectedItem == null)
            {
                message = "Vous devez indiquer une description.";
                caption = "Oups !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                // On verifie que l'identifiant n'existe pas déjà
                if (TBIdentifiantExigence.Text != exigence.Identifiant && FactoryService.CreateServiceExigence().IfIdentifiantExisting(exigence.Projet, TBIdentifiantExigence.Text))
                {
                    message = "Cette identifiant est déjà utilisé pour ce projet.";
                    caption = "Oups !";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    int type = (CBTypeExigences.SelectedItem as dynamic).Value;
                    FactoryService.CreateServiceExigence().UpdateExigence(exigence.Id, TBIdentifiantExigence.Text, TBDescription.Text, type, exigence.Projet);
                    message = "La modification a bien été effectuée.";
                    caption = "Félicitations !";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                    // On refresh le form Main de l'app
                    if (Application.OpenForms["Main"] != null)
                    {
                        (Application.OpenForms["Main"] as Main).RefreshInfosProjet(exigence.Projet);
                    }
                    this.Close();
                }
            }
        }
    }
}