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

namespace WindowsFormsApp.New
{
    public partial class NewExigence : Form
    {

        string message;
        string caption;
        int idProjet = (Application.OpenForms["Main"] as Main).idProjet;

        public NewExigence()
        {
            InitializeComponent();
            CBTypeExigences.Items.Clear();
            CBTypeExigences.DisplayMember = "Text";
            CBTypeExigences.ValueMember = "Value";
            foreach (TypeExigence type in FactoryService.CreateServiceTypeExigence().GetAllTypeExigences())
            {
                CBTypeExigences.Items.Add(new { Text = type.Label, Value = type.Id });
            }
            CBTypeExigences.SelectedIndex = 0;
        }

        private void NewExigence_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddExigence_Click(object sender, EventArgs e)
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
                if (FactoryService.CreateServiceExigence().IfIdentifiantExisting(idProjet, TBIdentifiantExigence.Text))
                {
                    message = "Cette identifiant est déjà utilisé pour ce projet.";
                    caption = "Oups !";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    int type = (CBTypeExigences.SelectedItem as dynamic).Value;
                    if (FactoryService.CreateServiceExigence().InsertExigence(TBIdentifiantExigence.Text, TBDescription.Text, type, idProjet) == 1)
                    {
                        message = "L'insertion a bien été effectuée.";
                        caption = "Félicitations !";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        // On refresh le form Main de l'app
                        if (Application.OpenForms["Main"] != null)
                        {
                            (Application.OpenForms["Main"] as Main).RefreshInfosProjet(idProjet);
                        }
                    }
                    else
                    {
                        message = "Une erreur est survenue. L'insertion n'a pas pu être effectuée.";
                        caption = "Oups !";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                    this.Close();
                }
            }
        }

        private void TBDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CBTypeExigences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBIdentifiantExigence_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
