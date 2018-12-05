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
    public partial class UpdateProjet : Form
    {
        public Projet projet;
        string message;
        string caption;
        public UpdateProjet()
        {
            InitializeComponent();
        }

        private void UpdateProjet_Load(object sender, EventArgs e)
        {
            // On recupere le projet que l'on souhaite modifier
            if (Application.OpenForms["Main"] != null)
            {
                projet = FactoryService.CreateServiceProjet().GetProjetById((Application.OpenForms["Main"] as Main).idProjet);
            }
            // On affiche les infos du projet
            Refresh();
            TBNomProjet.Text = projet.Nom;
            TBTrigrammeProjet.Text = projet.Trigramme;
            DTDateDebut.Value = projet.DateDebut;
            DTDateFinPrevue.Value = projet.DateFinPrevue;
        }

        public override void Refresh()
        {
            CBResponsableProjet.Items.Clear();
            CBResponsableProjet.DisplayMember = "Text";
            CBResponsableProjet.ValueMember = "Value";
            int cpt = 0;
            foreach (Trigramme tri in FactoryService.CreateServiceTrigramme().GetAllTrigrammes())
            {
                CBResponsableProjet.Items.Add(new { Text = tri.Nom, Value = tri.Id });
                if (tri.Id == projet.Responsable)
                    CBResponsableProjet.SelectedIndex = cpt;
                cpt++;
            }
        }

        private void BtnNewResponsableProjet_Click(object sender, EventArgs e)
        {
            NewTrigramme frmNewTrigramme = new NewTrigramme(this);
            frmNewTrigramme.ShowDialog(this);
            frmNewTrigramme.Dispose();
        }

        private void BtnNewProjet_Click(object sender, EventArgs e)
        {
            // On verifieque tous les champs on été saisis
            if (TBNomProjet.Text == "" || TBTrigrammeProjet.Text == "" || CBResponsableProjet.SelectedItem == null)
            {
                message = "Vous devez remplir tous les champs.";
                caption = "Oups !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                // On verifie que le trigramme est bien composé de 3 lettres
                if (TBTrigrammeProjet.Text.Count() != 3)
                {
                    message = "Votre trigramme doit obligatoirement se composer de trois lettres.";
                    caption = "Oups !";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    // On verifie que DateDebut est bien antèrieure à DateFinPrevue
                    if (DTDateDebut.Value.Date.CompareTo(DTDateFinPrevue.Value.Date) == 1)
                    {
                        message = "Votre date de début doit être antérieur à la date de fin prévue.";
                        caption = "Oups !";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        // On realise l'update du projet
                        FactoryService.CreateServiceProjet().UpdateProjet(TBNomProjet.Text, TBTrigrammeProjet.Text, (CBResponsableProjet.SelectedItem as dynamic).Value, DTDateDebut.Value, DTDateFinPrevue.Value, projet.Id);
                        // On affiche le resultat de l'update
                        message = "La mise à jour a bien été effectuée.";
                        caption = "Félicitation !";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        // On refresh le form Main de l'app
                        if (Application.OpenForms["Main"] != null)
                        {
                            (Application.OpenForms["Main"] as Main).RefreshInfosProjet(projet.Id);
                        }
                        // On ferme la form e modification
                        this.Close();
                    }
                }
            }
        }
    }
}
