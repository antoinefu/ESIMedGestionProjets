namespace WindowsFormsApp.New
{
    partial class NewExigence
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
            this.TBDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBTypeExigences = new System.Windows.Forms.ComboBox();
            this.BtnAddExigence = new System.Windows.Forms.Button();
            this.TBIdentifiantExigence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(84, 36);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(520, 134);
            this.TBDescription.TabIndex = 2;
            this.TBDescription.Text = "";
            this.TBDescription.TextChanged += new System.EventHandler(this.TBDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CBTypeExigences
            // 
            this.CBTypeExigences.FormattingEnabled = true;
            this.CBTypeExigences.Location = new System.Drawing.Point(331, 9);
            this.CBTypeExigences.Name = "CBTypeExigences";
            this.CBTypeExigences.Size = new System.Drawing.Size(273, 21);
            this.CBTypeExigences.TabIndex = 6;
            this.CBTypeExigences.SelectedIndexChanged += new System.EventHandler(this.CBTypeExigences_SelectedIndexChanged);
            // 
            // BtnAddExigence
            // 
            this.BtnAddExigence.Location = new System.Drawing.Point(84, 176);
            this.BtnAddExigence.Name = "BtnAddExigence";
            this.BtnAddExigence.Size = new System.Drawing.Size(520, 38);
            this.BtnAddExigence.TabIndex = 7;
            this.BtnAddExigence.Text = "Créer l\'exigence";
            this.BtnAddExigence.UseVisualStyleBackColor = true;
            this.BtnAddExigence.Click += new System.EventHandler(this.BtnAddExigence_Click);
            // 
            // TBIdentifiantExigence
            // 
            this.TBIdentifiantExigence.Location = new System.Drawing.Point(84, 10);
            this.TBIdentifiantExigence.Name = "TBIdentifiantExigence";
            this.TBIdentifiantExigence.Size = new System.Drawing.Size(148, 20);
            this.TBIdentifiantExigence.TabIndex = 8;
            this.TBIdentifiantExigence.TextChanged += new System.EventHandler(this.TBIdentifiantExigence_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Identifiant :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NewExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBIdentifiantExigence);
            this.Controls.Add(this.BtnAddExigence);
            this.Controls.Add(this.CBTypeExigences);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label1);
            this.Name = "NewExigence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle exigence";
            this.Load += new System.EventHandler(this.NewExigence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TBDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBTypeExigences;
        private System.Windows.Forms.Button BtnAddExigence;
        private System.Windows.Forms.TextBox TBIdentifiantExigence;
        private System.Windows.Forms.Label label2;
    }
}