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
            this.SuspendLayout();
            // 
            // BtnNewProjet
            // 
            this.BtnNewProjet.Location = new System.Drawing.Point(12, 12);
            this.BtnNewProjet.Name = "BtnNewProjet";
            this.BtnNewProjet.Size = new System.Drawing.Size(146, 39);
            this.BtnNewProjet.TabIndex = 3;
            this.BtnNewProjet.Text = "Nouveau projet";
            this.BtnNewProjet.UseVisualStyleBackColor = true;
            this.BtnNewProjet.Click += new System.EventHandler(this.BtnNewProjet_Click_1);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 566);
            this.Controls.Add(this.BtnNewProjet);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mon gestionnaire de projets";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNewProjet;
    }
}