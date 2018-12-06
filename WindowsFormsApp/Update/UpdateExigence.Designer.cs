namespace WindowsFormsApp.Update
{
    partial class UpdateExigence
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBIdentifiantExigence = new System.Windows.Forms.TextBox();
            this.BtnUpdateExigence = new System.Windows.Forms.Button();
            this.CBTypeExigences = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Identifiant :";
            // 
            // TBIdentifiantExigence
            // 
            this.TBIdentifiantExigence.Location = new System.Drawing.Point(82, 9);
            this.TBIdentifiantExigence.Name = "TBIdentifiantExigence";
            this.TBIdentifiantExigence.Size = new System.Drawing.Size(148, 20);
            this.TBIdentifiantExigence.TabIndex = 15;
            // 
            // BtnUpdateExigence
            // 
            this.BtnUpdateExigence.Location = new System.Drawing.Point(82, 175);
            this.BtnUpdateExigence.Name = "BtnUpdateExigence";
            this.BtnUpdateExigence.Size = new System.Drawing.Size(520, 38);
            this.BtnUpdateExigence.TabIndex = 14;
            this.BtnUpdateExigence.Text = "Modifier l\'exigence";
            this.BtnUpdateExigence.UseVisualStyleBackColor = true;
            this.BtnUpdateExigence.Click += new System.EventHandler(this.BtnUpdateExigence_Click);
            // 
            // CBTypeExigences
            // 
            this.CBTypeExigences.FormattingEnabled = true;
            this.CBTypeExigences.Location = new System.Drawing.Point(329, 8);
            this.CBTypeExigences.Name = "CBTypeExigences";
            this.CBTypeExigences.Size = new System.Drawing.Size(273, 21);
            this.CBTypeExigences.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type :";
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(82, 35);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(520, 134);
            this.TBDescription.TabIndex = 11;
            this.TBDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description :";
            // 
            // UpdateExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBIdentifiantExigence);
            this.Controls.Add(this.BtnUpdateExigence);
            this.Controls.Add(this.CBTypeExigences);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label1);
            this.Name = "UpdateExigence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification de l\'exigence";
            this.Load += new System.EventHandler(this.UpdateExigence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBIdentifiantExigence;
        private System.Windows.Forms.Button BtnUpdateExigence;
        private System.Windows.Forms.ComboBox CBTypeExigences;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TBDescription;
        private System.Windows.Forms.Label label1;
    }
}