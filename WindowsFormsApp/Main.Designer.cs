namespace WindowsFormsApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNewProjet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBListeProjets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGererProjet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabExigences = new System.Windows.Forms.TabPage();
            this.TabTaches = new System.Windows.Forms.TabPage();
            this.TabJalons = new System.Windows.Forms.TabPage();
            this.PnlProjet = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.LabDateFinPrevueProjet = new System.Windows.Forms.Label();
            this.LabDateDebutProjet = new System.Windows.Forms.Label();
            this.LabResponsableProjet = new System.Windows.Forms.Label();
            this.LabTrigrammeProjet = new System.Windows.Forms.Label();
            this.LabNomProjet = new System.Windows.Forms.Label();
            this.BtnDeleteProjet = new System.Windows.Forms.Button();
            this.BtnUpdateProjet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddExigence = new System.Windows.Forms.Button();
            this.BtnUpdateExigence = new System.Windows.Forms.Button();
            this.BtnDeleteExigence = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabExigences.SuspendLayout();
            this.PnlProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewProjet
            // 
            this.BtnNewProjet.BackColor = System.Drawing.Color.Maroon;
            this.BtnNewProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewProjet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNewProjet.Location = new System.Drawing.Point(802, 7);
            this.BtnNewProjet.Name = "BtnNewProjet";
            this.BtnNewProjet.Size = new System.Drawing.Size(180, 39);
            this.BtnNewProjet.TabIndex = 3;
            this.BtnNewProjet.Text = "Créer un nouveau projet";
            this.BtnNewProjet.UseVisualStyleBackColor = false;
            this.BtnNewProjet.Click += new System.EventHandler(this.BtnNewProjet_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choisir un projet :";
            // 
            // CBListeProjets
            // 
            this.CBListeProjets.FormattingEnabled = true;
            this.CBListeProjets.Location = new System.Drawing.Point(161, 18);
            this.CBListeProjets.Name = "CBListeProjets";
            this.CBListeProjets.Size = new System.Drawing.Size(397, 21);
            this.CBListeProjets.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ou";
            // 
            // BtnGererProjet
            // 
            this.BtnGererProjet.BackColor = System.Drawing.Color.Maroon;
            this.BtnGererProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGererProjet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGererProjet.Location = new System.Drawing.Point(566, 7);
            this.BtnGererProjet.Name = "BtnGererProjet";
            this.BtnGererProjet.Size = new System.Drawing.Size(180, 39);
            this.BtnGererProjet.TabIndex = 7;
            this.BtnGererProjet.Text = "Gérer";
            this.BtnGererProjet.UseVisualStyleBackColor = false;
            this.BtnGererProjet.Click += new System.EventHandler(this.BtnGererProjet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnNewProjet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CBListeProjets);
            this.panel1.Controls.Add(this.BtnGererProjet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 55);
            this.panel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabExigences);
            this.tabControl1.Controls.Add(this.TabTaches);
            this.tabControl1.Controls.Add(this.TabJalons);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 456);
            this.tabControl1.TabIndex = 9;
            // 
            // TabExigences
            // 
            this.TabExigences.BackColor = System.Drawing.Color.White;
            this.TabExigences.Controls.Add(this.BtnDeleteExigence);
            this.TabExigences.Controls.Add(this.BtnUpdateExigence);
            this.TabExigences.Controls.Add(this.BtnAddExigence);
            this.TabExigences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabExigences.Location = new System.Drawing.Point(4, 25);
            this.TabExigences.Name = "TabExigences";
            this.TabExigences.Padding = new System.Windows.Forms.Padding(3);
            this.TabExigences.Size = new System.Drawing.Size(954, 427);
            this.TabExigences.TabIndex = 0;
            this.TabExigences.Text = "Exigences";
            // 
            // TabTaches
            // 
            this.TabTaches.BackColor = System.Drawing.Color.White;
            this.TabTaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTaches.Location = new System.Drawing.Point(4, 25);
            this.TabTaches.Name = "TabTaches";
            this.TabTaches.Padding = new System.Windows.Forms.Padding(3);
            this.TabTaches.Size = new System.Drawing.Size(954, 427);
            this.TabTaches.TabIndex = 1;
            this.TabTaches.Text = "Tâches";
            // 
            // TabJalons
            // 
            this.TabJalons.BackColor = System.Drawing.Color.White;
            this.TabJalons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabJalons.Location = new System.Drawing.Point(4, 25);
            this.TabJalons.Name = "TabJalons";
            this.TabJalons.Size = new System.Drawing.Size(954, 427);
            this.TabJalons.TabIndex = 2;
            this.TabJalons.Text = "Jalons";
            // 
            // PnlProjet
            // 
            this.PnlProjet.BackColor = System.Drawing.Color.Silver;
            this.PnlProjet.Controls.Add(this.label13);
            this.PnlProjet.Controls.Add(this.LabDateFinPrevueProjet);
            this.PnlProjet.Controls.Add(this.LabDateDebutProjet);
            this.PnlProjet.Controls.Add(this.LabResponsableProjet);
            this.PnlProjet.Controls.Add(this.LabTrigrammeProjet);
            this.PnlProjet.Controls.Add(this.LabNomProjet);
            this.PnlProjet.Controls.Add(this.BtnDeleteProjet);
            this.PnlProjet.Controls.Add(this.BtnUpdateProjet);
            this.PnlProjet.Controls.Add(this.label7);
            this.PnlProjet.Controls.Add(this.label8);
            this.PnlProjet.Controls.Add(this.label9);
            this.PnlProjet.Controls.Add(this.label6);
            this.PnlProjet.Controls.Add(this.label5);
            this.PnlProjet.Controls.Add(this.label4);
            this.PnlProjet.Controls.Add(this.label3);
            this.PnlProjet.Controls.Add(this.tabControl1);
            this.PnlProjet.Location = new System.Drawing.Point(12, 88);
            this.PnlProjet.Name = "PnlProjet";
            this.PnlProjet.Size = new System.Drawing.Size(995, 601);
            this.PnlProjet.TabIndex = 0;
            this.PnlProjet.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(657, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "label13";
            // 
            // LabDateFinPrevueProjet
            // 
            this.LabDateFinPrevueProjet.AutoSize = true;
            this.LabDateFinPrevueProjet.Location = new System.Drawing.Point(657, 67);
            this.LabDateFinPrevueProjet.Name = "LabDateFinPrevueProjet";
            this.LabDateFinPrevueProjet.Size = new System.Drawing.Size(0, 13);
            this.LabDateFinPrevueProjet.TabIndex = 23;
            // 
            // LabDateDebutProjet
            // 
            this.LabDateDebutProjet.AutoSize = true;
            this.LabDateDebutProjet.Location = new System.Drawing.Point(657, 41);
            this.LabDateDebutProjet.Name = "LabDateDebutProjet";
            this.LabDateDebutProjet.Size = new System.Drawing.Size(0, 13);
            this.LabDateDebutProjet.TabIndex = 22;
            // 
            // LabResponsableProjet
            // 
            this.LabResponsableProjet.AutoSize = true;
            this.LabResponsableProjet.Location = new System.Drawing.Point(178, 94);
            this.LabResponsableProjet.Name = "LabResponsableProjet";
            this.LabResponsableProjet.Size = new System.Drawing.Size(0, 13);
            this.LabResponsableProjet.TabIndex = 21;
            // 
            // LabTrigrammeProjet
            // 
            this.LabTrigrammeProjet.AutoSize = true;
            this.LabTrigrammeProjet.Location = new System.Drawing.Point(178, 67);
            this.LabTrigrammeProjet.Name = "LabTrigrammeProjet";
            this.LabTrigrammeProjet.Size = new System.Drawing.Size(0, 13);
            this.LabTrigrammeProjet.TabIndex = 20;
            // 
            // LabNomProjet
            // 
            this.LabNomProjet.AutoSize = true;
            this.LabNomProjet.Location = new System.Drawing.Point(178, 41);
            this.LabNomProjet.Name = "LabNomProjet";
            this.LabNomProjet.Size = new System.Drawing.Size(0, 13);
            this.LabNomProjet.TabIndex = 19;
            // 
            // BtnDeleteProjet
            // 
            this.BtnDeleteProjet.BackColor = System.Drawing.Color.Maroon;
            this.BtnDeleteProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProjet.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProjet.Location = new System.Drawing.Point(798, 76);
            this.BtnDeleteProjet.Name = "BtnDeleteProjet";
            this.BtnDeleteProjet.Size = new System.Drawing.Size(180, 35);
            this.BtnDeleteProjet.TabIndex = 18;
            this.BtnDeleteProjet.Text = "Supprimer";
            this.BtnDeleteProjet.UseVisualStyleBackColor = false;
            this.BtnDeleteProjet.Click += new System.EventHandler(this.BtnDeleteProjet_Click);
            // 
            // BtnUpdateProjet
            // 
            this.BtnUpdateProjet.BackColor = System.Drawing.Color.Maroon;
            this.BtnUpdateProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProjet.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateProjet.Location = new System.Drawing.Point(798, 30);
            this.BtnUpdateProjet.Name = "BtnUpdateProjet";
            this.BtnUpdateProjet.Size = new System.Drawing.Size(180, 35);
            this.BtnUpdateProjet.TabIndex = 17;
            this.BtnUpdateProjet.Text = "Mettre à jour";
            this.BtnUpdateProjet.UseVisualStyleBackColor = false;
            this.BtnUpdateProjet.Click += new System.EventHandler(this.BtnUpdateProjet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date de fin théorique :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date de fin prévue :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date de début :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Responsable du projet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trigramme du projet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nom du projet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Infos sur le projet Projet";
            // 
            // BtnAddExigence
            // 
            this.BtnAddExigence.BackColor = System.Drawing.Color.Maroon;
            this.BtnAddExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddExigence.ForeColor = System.Drawing.Color.White;
            this.BtnAddExigence.Location = new System.Drawing.Point(8, 387);
            this.BtnAddExigence.Name = "BtnAddExigence";
            this.BtnAddExigence.Size = new System.Drawing.Size(180, 34);
            this.BtnAddExigence.TabIndex = 0;
            this.BtnAddExigence.Text = "Nouveau";
            this.BtnAddExigence.UseVisualStyleBackColor = false;
            this.BtnAddExigence.Click += new System.EventHandler(this.BtnAddExigence_Click);
            // 
            // BtnUpdateExigence
            // 
            this.BtnUpdateExigence.BackColor = System.Drawing.Color.Maroon;
            this.BtnUpdateExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateExigence.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateExigence.Location = new System.Drawing.Point(195, 387);
            this.BtnUpdateExigence.Name = "BtnUpdateExigence";
            this.BtnUpdateExigence.Size = new System.Drawing.Size(180, 34);
            this.BtnUpdateExigence.TabIndex = 1;
            this.BtnUpdateExigence.Text = "Mettre à jour";
            this.BtnUpdateExigence.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteExigence
            // 
            this.BtnDeleteExigence.BackColor = System.Drawing.Color.Maroon;
            this.BtnDeleteExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteExigence.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteExigence.Location = new System.Drawing.Point(378, 387);
            this.BtnDeleteExigence.Name = "BtnDeleteExigence";
            this.BtnDeleteExigence.Size = new System.Drawing.Size(180, 34);
            this.BtnDeleteExigence.TabIndex = 2;
            this.BtnDeleteExigence.Text = "Supprimer";
            this.BtnDeleteExigence.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1019, 701);
            this.Controls.Add(this.PnlProjet);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier le projet";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabExigences.ResumeLayout(false);
            this.PnlProjet.ResumeLayout(false);
            this.PnlProjet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNewProjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBListeProjets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGererProjet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabExigences;
        private System.Windows.Forms.TabPage TabTaches;
        private System.Windows.Forms.TabPage TabJalons;
        private System.Windows.Forms.Panel PnlProjet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabDateFinPrevueProjet;
        private System.Windows.Forms.Label LabDateDebutProjet;
        private System.Windows.Forms.Label LabResponsableProjet;
        private System.Windows.Forms.Label LabTrigrammeProjet;
        private System.Windows.Forms.Label LabNomProjet;
        private System.Windows.Forms.Button BtnDeleteProjet;
        private System.Windows.Forms.Button BtnUpdateProjet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddExigence;
        private System.Windows.Forms.Button BtnDeleteExigence;
        private System.Windows.Forms.Button BtnUpdateExigence;
    }
}