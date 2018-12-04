namespace WindowsFormsApp
{
    partial class NewTrigramme
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
            this.TBNewResponsable = new System.Windows.Forms.TextBox();
            this.BtnNewResponsable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trigramme :";
            // 
            // TBNewResponsable
            // 
            this.TBNewResponsable.Location = new System.Drawing.Point(128, 6);
            this.TBNewResponsable.MaxLength = 3;
            this.TBNewResponsable.Name = "TBNewResponsable";
            this.TBNewResponsable.Size = new System.Drawing.Size(120, 20);
            this.TBNewResponsable.TabIndex = 1;
            // 
            // BtnNewResponsable
            // 
            this.BtnNewResponsable.Location = new System.Drawing.Point(15, 32);
            this.BtnNewResponsable.Name = "BtnNewResponsable";
            this.BtnNewResponsable.Size = new System.Drawing.Size(233, 23);
            this.BtnNewResponsable.TabIndex = 2;
            this.BtnNewResponsable.Text = "Créer le résponsable";
            this.BtnNewResponsable.UseVisualStyleBackColor = true;
            this.BtnNewResponsable.Click += new System.EventHandler(this.BtnNewResponsable_Click);
            // 
            // NewTrigramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 64);
            this.Controls.Add(this.BtnNewResponsable);
            this.Controls.Add(this.TBNewResponsable);
            this.Controls.Add(this.label1);
            this.Name = "NewTrigramme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau résponsable";
            this.Load += new System.EventHandler(this.NewTrigramme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNewResponsable;
        private System.Windows.Forms.Button BtnNewResponsable;
    }
}