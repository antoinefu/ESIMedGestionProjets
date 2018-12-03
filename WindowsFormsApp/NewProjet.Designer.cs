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
            this.button1 = new System.Windows.Forms.Button();
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
            this.DTPDateDebutProjet = new System.Windows.Forms.DateTimePicker();
            this.DTPDateFinPrevueProjet = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer le projet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trigramme :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Résponsable :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date de début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date de fin prévue :";
            // 
            // TBNomProjet
            // 
            this.TBNomProjet.Location = new System.Drawing.Point(131, 15);
            this.TBNomProjet.Name = "TBNomProjet";
            this.TBNomProjet.Size = new System.Drawing.Size(192, 20);
            this.TBNomProjet.TabIndex = 6;
            // 
            // TBTrigrammeProjet
            // 
            this.TBTrigrammeProjet.Location = new System.Drawing.Point(131, 41);
            this.TBTrigrammeProjet.Name = "TBTrigrammeProjet";
            this.TBTrigrammeProjet.Size = new System.Drawing.Size(192, 20);
            this.TBTrigrammeProjet.TabIndex = 7;
            // 
            // CBResponsableProjet
            // 
            this.CBResponsableProjet.FormattingEnabled = true;
            this.CBResponsableProjet.Location = new System.Drawing.Point(131, 67);
            this.CBResponsableProjet.Name = "CBResponsableProjet";
            this.CBResponsableProjet.Size = new System.Drawing.Size(94, 21);
            this.CBResponsableProjet.TabIndex = 8;
            // 
            // BtnNewResponsableProjet
            // 
            this.BtnNewResponsableProjet.Location = new System.Drawing.Point(256, 67);
            this.BtnNewResponsableProjet.Name = "BtnNewResponsableProjet";
            this.BtnNewResponsableProjet.Size = new System.Drawing.Size(67, 23);
            this.BtnNewResponsableProjet.TabIndex = 9;
            this.BtnNewResponsableProjet.Text = "Nouveau";
            this.BtnNewResponsableProjet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ou";
            // 
            // DTPDateDebutProjet
            // 
            this.DTPDateDebutProjet.Location = new System.Drawing.Point(131, 96);
            this.DTPDateDebutProjet.Name = "DTPDateDebutProjet";
            this.DTPDateDebutProjet.Size = new System.Drawing.Size(192, 20);
            this.DTPDateDebutProjet.TabIndex = 11;
            // 
            // DTPDateFinPrevueProjet
            // 
            this.DTPDateFinPrevueProjet.Location = new System.Drawing.Point(131, 122);
            this.DTPDateFinPrevueProjet.Name = "DTPDateFinPrevueProjet";
            this.DTPDateFinPrevueProjet.Size = new System.Drawing.Size(192, 20);
            this.DTPDateFinPrevueProjet.TabIndex = 12;
            // 
            // NewProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 189);
            this.Controls.Add(this.DTPDateFinPrevueProjet);
            this.Controls.Add(this.DTPDateDebutProjet);
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
            this.Controls.Add(this.button1);
            this.Name = "NewProjet";
            this.Text = "Nouveau projet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DateTimePicker DTPDateDebutProjet;
        private System.Windows.Forms.DateTimePicker DTPDateFinPrevueProjet;
    }
}

