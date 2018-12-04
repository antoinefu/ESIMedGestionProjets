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
    public partial class Main : Form
    {

        string message;
        string caption;

        public Main()
        {
            InitializeComponent();
        }

        private void BtnNewProjet_Click(object sender, EventArgs e)
        {
            NewProjet frmNewProjet = new NewProjet();
            frmNewProjet.ShowDialog(this);
            frmNewProjet.Dispose();
        }

        public void Init()
        {
            // On charge les différents projets dans le combobox
            CBListeProjets.Items.Clear();
            CBListeProjets.DisplayMember = "Text";
            CBListeProjets.ValueMember = "Value";
            foreach (Projet projet in FactoryService.CreateServiceProjet().GetAllProjets())
            {
                CBListeProjets.Items.Add(new { Text = projet.Trigramme + " - " + projet.Nom, Value = projet.Id });
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void BtnNewProjet_Click_1(object sender, EventArgs e)
        {
            NewProjet frmNewProjet = new NewProjet();
            frmNewProjet.ShowDialog(this);
            frmNewProjet.Dispose();
        }

        private void BtnGererProjet_Click(object sender, EventArgs e)
        {
            if (CBListeProjets.SelectedItem == null)
            {
                message = "Vous devez selectionner un projet à gérer.";
                caption = "Oups !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                // On récupère l'id du projet selectionné
                int idProjet = (CBListeProjets.SelectedItem as dynamic).Value;
                // On met à jour l'affichage des infos du projet
                Projet projet = FactoryService.CreateServiceProjet().GetProjetById(idProjet);
                LabNomProjet.Text = projet.Nom;
                LabTrigrammeProjet.Text = projet.Trigramme;
                LabResponsableProjet.Text = FactoryService.CreateServiceTrigramme().GetTrigrammeById(projet.Responsable).Nom;
                LabDateDebutProjet.Text = projet.DateDebut.ToLongDateString();
                LabDateFinPrevueProjet.Text = projet.DateFinPrevue.ToLongDateString();
                // On met à jour l'affichage des exigences

                // On met à jour l'affichage des tâches

                // On met à jour l'affichage des jalons
            }

        }
    }
}
