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
    public partial class NewTrigramme : Form
    {

        Form previousForm;

        public NewTrigramme(Form p_previousForm)
        {
            previousForm = p_previousForm;
            InitializeComponent();
        }

        private void BtnNewResponsable_Click(object sender, EventArgs e)
        {
            string message;
            string caption;
            if (TBNewResponsable.Text.Length != 3)
            {
                // On verifie que la saisie est bonne
                message = "Votre trigramme doit obligatoirement se composer de trois lettres.";
                caption = "Oups !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                // On verifie que le trigramme n'existe pas déja en base
                if (FactoryService.CreateServiceTrigramme().IfTrigrammeExisting(TBNewResponsable.Text))
                {
                    message = "Ce trigramme de résponsable existe déjà.";
                    caption = "Oups !";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    // On effectue l'insert
                    int result = FactoryService.CreateServiceTrigramme().NewTrigramme(TBNewResponsable.Text);
                    // On affiche le resultat de l'insert
                    if (result == 1)
                    {
                        message = "L'insertion a bien été effectuée.";
                        caption = "Félicitation !";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        previousForm.Refresh();
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

        private void NewTrigramme_Load(object sender, EventArgs e)
        {

        }
    }
}
