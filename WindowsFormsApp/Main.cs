﻿using bean;
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
using WindowsFormsApp.New;
using WindowsFormsApp.Update;

namespace WindowsFormsApp
{
    public partial class Main : Form
    {

        string message;
        string caption;
        public int idProjet; 

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

        public void Refresh()
        {
            // On charge les différents projets dans le combobox
            CBListeProjets.Items.Clear();
            CBListeProjets.DisplayMember = "Text";
            CBListeProjets.ValueMember = "Value";
            foreach (Projet projet in FactoryService.CreateServiceProjet().GetAllProjets())
            {
                CBListeProjets.Items.Add(new { Text = projet.Trigramme + " - " + projet.Nom, Value = projet.Id });
            }
            CBListeProjets.SelectedItem = null;
        }

        public void Init()
        {
            Refresh();
            CBListeProjets.Text = "";
            PnlProjet.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Refresh();
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
                idProjet = (CBListeProjets.SelectedItem as dynamic).Value;
                RefreshInfosProjet(idProjet);
            }

        }

        public void RefreshInfosProjet(int p_idProjet)
        {
            // On refresh le header
            Refresh();
            // On affiche le panl projet
            PnlProjet.Visible = true;
            // On met à jour l'affichage des infos du projet
            Projet projet = FactoryService.CreateServiceProjet().GetProjetById(p_idProjet);
            LabNomProjet.Text = projet.Nom;
            LabTrigrammeProjet.Text = projet.Trigramme;
            LabResponsableProjet.Text = FactoryService.CreateServiceTrigramme().GetTrigrammeById(projet.Responsable).Nom;
            LabDateDebutProjet.Text = projet.DateDebut.ToLongDateString();
            LabDateFinPrevueProjet.Text = projet.DateFinPrevue.ToLongDateString();
            // On met à jour l'affichage des exigences
            DGVExigences.Rows.Clear();
            foreach (Exigence row in FactoryService.CreateServiceExigence().GetExigenceByProjetId(idProjet))
            {
                string fonctionnelle = "Oui";
                string type = "(Vide)";
                if (!row.Fonctionnelle)
                {
                    fonctionnelle = "Non";
                    type = FactoryService.CreateServiceTypeExigence().GetTypeExigenceById(row.Type).Label;
                }
                DGVExigences.Rows.Add(row.Id, row.Decription, fonctionnelle, type);
            }
            // On met à jour l'affichage des tâches

            // On met à jour l'affichage des jalons
        }

        private void BtnDeleteProjet_Click(object sender, EventArgs e)
        {
            // On demande à l'utilisateur la confirmation de la suppression
            if (MessageBox.Show("Voyulez-vous vraiment supprimer définitivement ce proejt ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // On effectue la suppression
                FactoryService.CreateServiceProjet().DeleteProjet(idProjet);
                // On reinitialise l'ffichage
                Init();
                // On confirme la suppression à l'utilisateur
                message = "La suppression a bien été effectuée.";
                caption = "Félicitation !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void BtnUpdateProjet_Click(object sender, EventArgs e)
        {
            UpdateProjet frmUpdateProjet = new UpdateProjet();
            frmUpdateProjet.ShowDialog(this);
            frmUpdateProjet.Dispose();
        }

        private void BtnAddExigence_Click(object sender, EventArgs e)
        {
            NewExigence frmNewExigence = new NewExigence();
            frmNewExigence.ShowDialog(this);
            frmNewExigence.Dispose();
        }
    }
}
