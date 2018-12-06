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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNewProjet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBListeProjets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGererProjet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabExigences = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDeleteExigence = new System.Windows.Forms.Button();
            this.DGVExigences = new System.Windows.Forms.DataGridView();
            this.BtnAddExigence = new System.Windows.Forms.Button();
            this.TabTaches = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnUpdateTache = new System.Windows.Forms.Button();
            this.BtnNewTache = new System.Windows.Forms.Button();
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTaches = new System.Windows.Forms.DataGridView();
            this.Id_tache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle_tache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat_tache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable_tache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.correspondTableAdapter1 = new Service_DA.DataSetTableAdapters.CorrespondTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabExigences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExigences)).BeginInit();
            this.TabTaches.SuspendLayout();
            this.TabJalons.SuspendLayout();
            this.PnlProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaches)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNewProjet
            // 
            this.BtnNewProjet.BackColor = System.Drawing.Color.Maroon;
            this.BtnNewProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewProjet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNewProjet.Location = new System.Drawing.Point(896, 8);
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
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choisir un projet existant :";
            // 
            // CBListeProjets
            // 
            this.CBListeProjets.FormattingEnabled = true;
            this.CBListeProjets.Location = new System.Drawing.Point(222, 18);
            this.CBListeProjets.Name = "CBListeProjets";
            this.CBListeProjets.Size = new System.Drawing.Size(419, 21);
            this.CBListeProjets.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(854, 20);
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
            this.BtnGererProjet.Location = new System.Drawing.Point(660, 8);
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
            this.panel1.Size = new System.Drawing.Size(1094, 55);
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
            this.tabControl1.Size = new System.Drawing.Size(1056, 491);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabExigences
            // 
            this.TabExigences.BackColor = System.Drawing.Color.White;
            this.TabExigences.Controls.Add(this.label10);
            this.TabExigences.Controls.Add(this.BtnDeleteExigence);
            this.TabExigences.Controls.Add(this.DGVExigences);
            this.TabExigences.Controls.Add(this.BtnAddExigence);
            this.TabExigences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabExigences.Location = new System.Drawing.Point(4, 25);
            this.TabExigences.Name = "TabExigences";
            this.TabExigences.Padding = new System.Windows.Forms.Padding(3);
            this.TabExigences.Size = new System.Drawing.Size(1048, 462);
            this.TabExigences.TabIndex = 0;
            this.TabExigences.Text = "Exigences";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(891, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "(Double click pour mdifier)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // BtnDeleteExigence
            // 
            this.BtnDeleteExigence.BackColor = System.Drawing.Color.Maroon;
            this.BtnDeleteExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteExigence.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteExigence.Location = new System.Drawing.Point(202, 422);
            this.BtnDeleteExigence.Name = "BtnDeleteExigence";
            this.BtnDeleteExigence.Size = new System.Drawing.Size(180, 34);
            this.BtnDeleteExigence.TabIndex = 4;
            this.BtnDeleteExigence.Text = "Supprimer";
            this.BtnDeleteExigence.UseVisualStyleBackColor = false;
            this.BtnDeleteExigence.Click += new System.EventHandler(this.BtnDeleteExigence_Click);
            // 
            // DGVExigences
            // 
            this.DGVExigences.AllowUserToAddRows = false;
            this.DGVExigences.BackgroundColor = System.Drawing.Color.Silver;
            this.DGVExigences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVExigences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.identifiant,
            this.Description,
            this.Type});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExigences.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVExigences.Location = new System.Drawing.Point(16, 17);
            this.DGVExigences.MultiSelect = false;
            this.DGVExigences.Name = "DGVExigences";
            this.DGVExigences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVExigences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExigences.Size = new System.Drawing.Size(1014, 399);
            this.DGVExigences.TabIndex = 3;
            this.DGVExigences.DoubleClick += new System.EventHandler(this.DGVExigences_DoubleClick);
            // 
            // BtnAddExigence
            // 
            this.BtnAddExigence.BackColor = System.Drawing.Color.Maroon;
            this.BtnAddExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddExigence.ForeColor = System.Drawing.Color.White;
            this.BtnAddExigence.Location = new System.Drawing.Point(16, 422);
            this.BtnAddExigence.Name = "BtnAddExigence";
            this.BtnAddExigence.Size = new System.Drawing.Size(180, 34);
            this.BtnAddExigence.TabIndex = 0;
            this.BtnAddExigence.Text = "Nouveau";
            this.BtnAddExigence.UseVisualStyleBackColor = false;
            this.BtnAddExigence.Click += new System.EventHandler(this.BtnAddExigence_Click);
            // 
            // TabTaches
            // 
            this.TabTaches.BackColor = System.Drawing.Color.White;
            this.TabTaches.Controls.Add(this.label12);
            this.TabTaches.Controls.Add(this.richTextBox1);
            this.TabTaches.Controls.Add(this.DGVTaches);
            this.TabTaches.Controls.Add(this.label11);
            this.TabTaches.Controls.Add(this.BtnUpdateTache);
            this.TabTaches.Controls.Add(this.BtnNewTache);
            this.TabTaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTaches.Location = new System.Drawing.Point(4, 25);
            this.TabTaches.Name = "TabTaches";
            this.TabTaches.Padding = new System.Windows.Forms.Padding(3);
            this.TabTaches.Size = new System.Drawing.Size(1048, 462);
            this.TabTaches.TabIndex = 1;
            this.TabTaches.Text = "Tâches";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(797, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "(Double click pour mdifier)";
            // 
            // BtnUpdateTache
            // 
            this.BtnUpdateTache.BackColor = System.Drawing.Color.Maroon;
            this.BtnUpdateTache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateTache.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateTache.Location = new System.Drawing.Point(202, 422);
            this.BtnUpdateTache.Name = "BtnUpdateTache";
            this.BtnUpdateTache.Size = new System.Drawing.Size(180, 34);
            this.BtnUpdateTache.TabIndex = 7;
            this.BtnUpdateTache.Text = "Supprimer";
            this.BtnUpdateTache.UseVisualStyleBackColor = false;
            // 
            // BtnNewTache
            // 
            this.BtnNewTache.BackColor = System.Drawing.Color.Maroon;
            this.BtnNewTache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewTache.ForeColor = System.Drawing.Color.White;
            this.BtnNewTache.Location = new System.Drawing.Point(16, 422);
            this.BtnNewTache.Name = "BtnNewTache";
            this.BtnNewTache.Size = new System.Drawing.Size(180, 34);
            this.BtnNewTache.TabIndex = 6;
            this.BtnNewTache.Text = "Nouveau";
            this.BtnNewTache.UseVisualStyleBackColor = false;
            // 
            // TabJalons
            // 
            this.TabJalons.BackColor = System.Drawing.Color.White;
            this.TabJalons.Controls.Add(this.label14);
            this.TabJalons.Controls.Add(this.button1);
            this.TabJalons.Controls.Add(this.button2);
            this.TabJalons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabJalons.Location = new System.Drawing.Point(4, 25);
            this.TabJalons.Name = "TabJalons";
            this.TabJalons.Size = new System.Drawing.Size(1048, 462);
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
            this.PnlProjet.Size = new System.Drawing.Size(1094, 631);
            this.PnlProjet.TabIndex = 0;
            this.PnlProjet.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(690, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "label13";
            // 
            // LabDateFinPrevueProjet
            // 
            this.LabDateFinPrevueProjet.AutoSize = true;
            this.LabDateFinPrevueProjet.Location = new System.Drawing.Point(690, 62);
            this.LabDateFinPrevueProjet.Name = "LabDateFinPrevueProjet";
            this.LabDateFinPrevueProjet.Size = new System.Drawing.Size(0, 13);
            this.LabDateFinPrevueProjet.TabIndex = 23;
            // 
            // LabDateDebutProjet
            // 
            this.LabDateDebutProjet.AutoSize = true;
            this.LabDateDebutProjet.Location = new System.Drawing.Point(690, 36);
            this.LabDateDebutProjet.Name = "LabDateDebutProjet";
            this.LabDateDebutProjet.Size = new System.Drawing.Size(0, 13);
            this.LabDateDebutProjet.TabIndex = 22;
            // 
            // LabResponsableProjet
            // 
            this.LabResponsableProjet.AutoSize = true;
            this.LabResponsableProjet.Location = new System.Drawing.Point(211, 89);
            this.LabResponsableProjet.Name = "LabResponsableProjet";
            this.LabResponsableProjet.Size = new System.Drawing.Size(0, 13);
            this.LabResponsableProjet.TabIndex = 21;
            // 
            // LabTrigrammeProjet
            // 
            this.LabTrigrammeProjet.AutoSize = true;
            this.LabTrigrammeProjet.Location = new System.Drawing.Point(211, 62);
            this.LabTrigrammeProjet.Name = "LabTrigrammeProjet";
            this.LabTrigrammeProjet.Size = new System.Drawing.Size(0, 13);
            this.LabTrigrammeProjet.TabIndex = 20;
            // 
            // LabNomProjet
            // 
            this.LabNomProjet.AutoSize = true;
            this.LabNomProjet.Location = new System.Drawing.Point(211, 36);
            this.LabNomProjet.Name = "LabNomProjet";
            this.LabNomProjet.Size = new System.Drawing.Size(0, 13);
            this.LabNomProjet.TabIndex = 19;
            // 
            // BtnDeleteProjet
            // 
            this.BtnDeleteProjet.BackColor = System.Drawing.Color.Maroon;
            this.BtnDeleteProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProjet.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProjet.Location = new System.Drawing.Point(896, 72);
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
            this.BtnUpdateProjet.Location = new System.Drawing.Point(896, 26);
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
            this.label7.Location = new System.Drawing.Point(539, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date de fin théorique :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date de fin prévue :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date de début :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Responsable du projet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trigramme du projet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 38);
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
            // Id
            // 
            this.Id.FillWeight = 20F;
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id.";
            this.Id.Name = "Id";
            this.Id.Width = 5;
            // 
            // identifiant
            // 
            this.identifiant.Frozen = true;
            this.identifiant.HeaderText = "Identifiant";
            this.identifiant.Name = "identifiant";
            this.identifiant.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.Frozen = true;
            this.Description.HeaderText = "Descriptif";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 680;
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 190;
            // 
            // DGVTaches
            // 
            this.DGVTaches.AllowUserToAddRows = false;
            this.DGVTaches.BackgroundColor = System.Drawing.Color.Silver;
            this.DGVTaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_tache,
            this.Libelle_tache,
            this.Etat_tache,
            this.Responsable_tache});
            this.DGVTaches.Location = new System.Drawing.Point(16, 16);
            this.DGVTaches.Name = "DGVTaches";
            this.DGVTaches.Size = new System.Drawing.Size(424, 400);
            this.DGVTaches.TabIndex = 9;
            // 
            // Id_tache
            // 
            this.Id_tache.HeaderText = "Id";
            this.Id_tache.Name = "Id_tache";
            this.Id_tache.Visible = false;
            // 
            // Libelle_tache
            // 
            this.Libelle_tache.HeaderText = "Libellé ";
            this.Libelle_tache.Name = "Libelle_tache";
            this.Libelle_tache.Width = 250;
            // 
            // Etat_tache
            // 
            this.Etat_tache.HeaderText = "Etat";
            this.Etat_tache.Name = "Etat_tache";
            this.Etat_tache.Width = 80;
            // 
            // Responsable_tache
            // 
            this.Responsable_tache.HeaderText = "Resp.";
            this.Responsable_tache.Name = "Responsable_tache";
            this.Responsable_tache.Width = 50;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(449, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(582, 154);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(446, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Description :";
            // 
            // correspondTableAdapter1
            // 
            this.correspondTableAdapter1.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(887, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "(Double click pour mdifier)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(198, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Nouveau";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1118, 731);
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
            this.TabExigences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExigences)).EndInit();
            this.TabTaches.ResumeLayout(false);
            this.TabTaches.PerformLayout();
            this.TabJalons.ResumeLayout(false);
            this.TabJalons.PerformLayout();
            this.PnlProjet.ResumeLayout(false);
            this.PnlProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaches)).EndInit();
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
        private System.Windows.Forms.DataGridView DGVExigences;
        private System.Windows.Forms.Button BtnDeleteExigence;
        private System.Windows.Forms.Label label10;
        private Service_DA.DataSetTableAdapters.CorrespondTableAdapter correspondTableAdapter1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnUpdateTache;
        private System.Windows.Forms.Button BtnNewTache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridView DGVTaches;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_tache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle_tache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat_tache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable_tache;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}