namespace WindowsFormsApp
{
    partial class NewProjet
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNewProjet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBNomProjet = new System.Windows.Forms.TextBox();
            this.TBTrigrammeProjet = new System.Windows.Forms.TextBox();
            this.CBResponsableProjet = new System.Windows.Forms.ComboBox();
            this.BtnNewResponsableProjet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DTDateDebut = new System.Windows.Forms.DateTimePicker();
            this.DTDateFinPrevue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnNewProjet
            // 
            this.BtnNewProjet.BackColor = System.Drawing.Color.White;
            this.BtnNewProjet.Location = new System.Drawing.Point(64, 169);
            this.BtnNewProjet.Name = "BtnNewProjet";
            this.BtnNewProjet.Size = new System.Drawing.Size(276, 38);
            this.BtnNewProjet.TabIndex = 0;
            this.BtnNewProjet.Text = "Créer le projet";
            this.BtnNewProjet.UseVisualStyleBackColor = false;
            this.BtnNewProjet.Click += new System.EventHandler(this.BtnNewProjet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trigramme :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Résponsable :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date de début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date de fin prévue :";
            // 
            // TBNomProjet
            // 
            this.TBNomProjet.Location = new System.Drawing.Point(140, 15);
            this.TBNomProjet.Name = "TBNomProjet";
            this.TBNomProjet.Size = new System.Drawing.Size(227, 20);
            this.TBNomProjet.TabIndex = 6;
            // 
            // TBTrigrammeProjet
            // 
            this.TBTrigrammeProjet.Location = new System.Drawing.Point(140, 41);
            this.TBTrigrammeProjet.MaxLength = 3;
            this.TBTrigrammeProjet.Name = "TBTrigrammeProjet";
            this.TBTrigrammeProjet.Size = new System.Drawing.Size(227, 20);
            this.TBTrigrammeProjet.TabIndex = 7;
            // 
            // CBResponsableProjet
            // 
            this.CBResponsableProjet.FormattingEnabled = true;
            this.CBResponsableProjet.Location = new System.Drawing.Point(140, 67);
            this.CBResponsableProjet.Name = "CBResponsableProjet";
            this.CBResponsableProjet.Size = new System.Drawing.Size(94, 21);
            this.CBResponsableProjet.TabIndex = 8;
            // 
            // BtnNewResponsableProjet
            // 
            this.BtnNewResponsableProjet.Location = new System.Drawing.Point(300, 67);
            this.BtnNewResponsableProjet.Name = "BtnNewResponsableProjet";
            this.BtnNewResponsableProjet.Size = new System.Drawing.Size(67, 23);
            this.BtnNewResponsableProjet.TabIndex = 9;
            this.BtnNewResponsableProjet.Text = "Nouveau";
            this.BtnNewResponsableProjet.UseVisualStyleBackColor = true;
            this.BtnNewResponsableProjet.Click += new System.EventHandler(this.BtnNewResponsableProjet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ou";
            // 
            // DTDateDebut
            // 
            this.DTDateDebut.Location = new System.Drawing.Point(140, 96);
            this.DTDateDebut.Name = "DTDateDebut";
            this.DTDateDebut.Size = new System.Drawing.Size(227, 20);
            this.DTDateDebut.TabIndex = 11;
            // 
            // DTDateFinPrevue
            // 
            this.DTDateFinPrevue.Location = new System.Drawing.Point(140, 122);
            this.DTDateFinPrevue.Name = "DTDateFinPrevue";
            this.DTDateFinPrevue.Size = new System.Drawing.Size(227, 20);
            this.DTDateFinPrevue.TabIndex = 12;
            // 
            // NewProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 219);
            this.Controls.Add(this.DTDateFinPrevue);
            this.Controls.Add(this.DTDateDebut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnNewResponsableProjet);
            this.Controls.Add(this.CBResponsableProjet);
            this.Controls.Add(this.TBTrigrammeProjet);
            this.Controls.Add(this.TBNomProjet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNewProjet);
            this.Name = "NewProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau projet";
            this.Load += new System.EventHandler(this.NewProjet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNewProjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBNomProjet;
        private System.Windows.Forms.TextBox TBTrigrammeProjet;
        private System.Windows.Forms.ComboBox CBResponsableProjet;
        private System.Windows.Forms.Button BtnNewResponsableProjet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTDateDebut;
        private System.Windows.Forms.DateTimePicker DTDateFinPrevue;
    }
}

