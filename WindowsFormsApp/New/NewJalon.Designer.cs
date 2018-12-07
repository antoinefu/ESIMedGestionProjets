namespace WindowsFormsApp.New
{
    partial class NewJalon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBLibelleJalon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnNewResponsableProjet = new System.Windows.Forms.Button();
            this.CBResponsableJalon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPDateJalon = new System.Windows.Forms.DateTimePicker();
            this.BtnNewJalon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de livraison prévue :";
            // 
            // TBLibelleJalon
            // 
            this.TBLibelleJalon.Location = new System.Drawing.Point(159, 6);
            this.TBLibelleJalon.Name = "TBLibelleJalon";
            this.TBLibelleJalon.Size = new System.Drawing.Size(226, 20);
            this.TBLibelleJalon.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ou";
            // 
            // BtnNewResponsableProjet
            // 
            this.BtnNewResponsableProjet.Location = new System.Drawing.Point(318, 30);
            this.BtnNewResponsableProjet.Name = "BtnNewResponsableProjet";
            this.BtnNewResponsableProjet.Size = new System.Drawing.Size(67, 23);
            this.BtnNewResponsableProjet.TabIndex = 13;
            this.BtnNewResponsableProjet.Text = "Nouveau";
            this.BtnNewResponsableProjet.UseVisualStyleBackColor = true;
            this.BtnNewResponsableProjet.Click += new System.EventHandler(this.BtnNewResponsableProjet_Click);
            // 
            // CBResponsableJalon
            // 
            this.CBResponsableJalon.FormattingEnabled = true;
            this.CBResponsableJalon.Location = new System.Drawing.Point(158, 30);
            this.CBResponsableJalon.Name = "CBResponsableJalon";
            this.CBResponsableJalon.Size = new System.Drawing.Size(94, 21);
            this.CBResponsableJalon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Résponsable :";
            // 
            // DTPDateJalon
            // 
            this.DTPDateJalon.Location = new System.Drawing.Point(158, 59);
            this.DTPDateJalon.Name = "DTPDateJalon";
            this.DTPDateJalon.Size = new System.Drawing.Size(227, 20);
            this.DTPDateJalon.TabIndex = 15;
            // 
            // BtnNewJalon
            // 
            this.BtnNewJalon.Location = new System.Drawing.Point(12, 95);
            this.BtnNewJalon.Name = "BtnNewJalon";
            this.BtnNewJalon.Size = new System.Drawing.Size(373, 36);
            this.BtnNewJalon.TabIndex = 16;
            this.BtnNewJalon.Text = "Créer le jalon";
            this.BtnNewJalon.UseVisualStyleBackColor = true;
            this.BtnNewJalon.Click += new System.EventHandler(this.BtnNewJalon_Click);
            // 
            // NewJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 141);
            this.Controls.Add(this.BtnNewJalon);
            this.Controls.Add(this.DTPDateJalon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnNewResponsableProjet);
            this.Controls.Add(this.CBResponsableJalon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBLibelleJalon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewJalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau jalon";
            this.Load += new System.EventHandler(this.NewJalon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBLibelleJalon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNewResponsableProjet;
        private System.Windows.Forms.ComboBox CBResponsableJalon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPDateJalon;
        private System.Windows.Forms.Button BtnNewJalon;
    }
}