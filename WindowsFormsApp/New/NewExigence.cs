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
            RBYes.Checked = true;
            CBTypeExigences.Enabled = false;
        }

        private void NewExigence_Load(object sender, EventArgs e)
        {

        }

        private void RBNo_CheckedChanged(object sender, EventArgs e)
        {
            CBTypeExigences.Enabled = true;
        }

        private void RBYes_CheckedChanged(object sender, EventArgs e)
        {
            CBTypeExigences.Enabled = false;
        }

        private void BtnAddExigence_Click(object sender, EventArgs e)
        {
            // On verifieque tous les champs on été saisis
            if (TBDescription.Text == "")
            {
                message = "Vous devez indiquer une description.";
                caption = "Oups !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                bool fonctionnelle = true;
                int type = 0;
                int idProjet = (Application.OpenForms["Main"] as Main).idProjet; ;
                if (RBNo.Checked)
                {
                    fonctionnelle = false;
                    type = (CBTypeExigences.SelectedItem as dynamic).Value;
                }
                if (FactoryService.CreateServiceExigence().InsertExigence(TBDescription.Text, fonctionnelle, type, idProjet) == 1)
                {
                    message = "L'insertion a bien été effectuée.";
                    caption = "Félicitations !";
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
                this.Close();
            }
        }
    }
}
