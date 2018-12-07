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
    public partial class NewJalon : Form
    {
        public string message;
        public string caption;
        public int idProjet;
        public NewJalon(int p_idProjet)
        {
            InitializeComponent();
            this.idProjet = p_idProjet;
            Refresh();
        }

        public override void Refresh()
        {
            CBResponsableJalon.Items.Clear();
            CBResponsableJalon.DisplayMember = "Text";
            CBResponsableJalon.ValueMember = "Value";
            foreach (Trigramme tri in FactoryService.CreateServiceTrigramme().GetAllTrigrammes())
            {
                CBResponsableJalon.Items.Add(new { Text = tri.Nom, Value = tri.Id });
            }
        }

        private void NewJalon_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewJalon_Click(object sender, EventArgs e)
        {
            // On verifieque tous les champs on été saisis
            if (TBLibelleJalon.Text == "" || CBResponsableJalon.SelectedItem == null)
            {
                message = "Vous devez remplir tous les champs.";
                caption = "Oups !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                // On realise l'insertion du nouveau projet
                int resultInsert = FactoryService.CreateServiceJalon().InsertJalon(0, TBLibelleJalon.Text, (CBResponsableJalon.SelectedItem as dynamic).Value, DTPDateJalon.Value, default(DateTime), idProjet);
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
                // On refresh le form Main de l'app
                if (Application.OpenForms["Main"] != null)
                {
                    (Application.OpenForms["Main"] as Main).RefreshInfosProjet(idProjet);
                }
                // On ferme la form d'ajout
                this.Close();
            }
        }

        private void BtnNewResponsableProjet_Click(object sender, EventArgs e)
        {
            NewTrigramme frmNewTrigramme = new NewTrigramme(this);
            frmNewTrigramme.ShowDialog(this);
            frmNewTrigramme.Dispose();
        }
    }
}
