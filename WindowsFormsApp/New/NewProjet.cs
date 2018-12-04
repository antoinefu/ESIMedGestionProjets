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

namespace WindowsFormsApp
{
    public partial class NewProjet : Form
    {

        string message;
        string caption;

        public NewProjet()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            CBResponsableProjet.Items.Clear();
            CBResponsableProjet.DisplayMember = "Text";
            CBResponsableProjet.ValueMember = "Value";
            foreach (Trigramme tri in FactoryService.CreateServiceTrigramme().GetAllTrigrammes())
            {
                CBResponsableProjet.Items.Add(new { Text = tri.Nom, Value = tri.Id });
            }
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
                        // On realise l'insertion du nouveau projet
                        int resultInsert = FactoryService.CreateServiceProjet().NewProjet(TBNomProjet.Text, TBTrigrammeProjet.Text, (CBResponsableProjet.SelectedItem as dynamic).Value, DTDateDebut.Value, DTDateFinPrevue.Value);
                        // On affiche le resultat de l'insertion
                        if (resultInsert == 1)
                        {
                            message = "L'insertion a bien été effectuée.";
                            caption = "Félicitation !";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, buttons);
                        }
                        else
                        {
                            message = "Une erreur est survenue. L'insertion n'a pas pu être effectuée.";
                            caption = "Oups !";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, buttons);
                        }
                        // On ferme la form d'ajout
                        this.Close();
                    }
                }
            }
        }

        private void BtnNewResponsableProjet_Click(object sender, EventArgs e)
        {
            NewTrigramme frmNewTrigramme = new NewTrigramme();
            frmNewTrigramme.ShowDialog(this);
            frmNewTrigramme.Dispose();
        }

        private void NewProjet_Load(object sender, EventArgs e)
        {

        }
    }
}
