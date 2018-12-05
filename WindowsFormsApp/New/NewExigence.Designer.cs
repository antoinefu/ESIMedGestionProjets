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
            this.label2 = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.RichTextBox();
            this.RBYes = new System.Windows.Forms.RadioButton();
            this.RBNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CBTypeExigences = new System.Windows.Forms.ComboBox();
            this.BtnAddExigence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fonctionnelle :";
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(108, 6);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(250, 105);
            this.TBDescription.TabIndex = 2;
            this.TBDescription.Text = "";
            // 
            // RBYes
            // 
            this.RBYes.AutoSize = true;
            this.RBYes.Location = new System.Drawing.Point(108, 117);
            this.RBYes.Name = "RBYes";
            this.RBYes.Size = new System.Drawing.Size(41, 17);
            this.RBYes.TabIndex = 3;
            this.RBYes.TabStop = true;
            this.RBYes.Text = "Oui";
            this.RBYes.UseVisualStyleBackColor = true;
            this.RBYes.CheckedChanged += new System.EventHandler(this.RBYes_CheckedChanged);
            // 
            // RBNo
            // 
            this.RBNo.AutoSize = true;
            this.RBNo.Location = new System.Drawing.Point(167, 117);
            this.RBNo.Name = "RBNo";
            this.RBNo.Size = new System.Drawing.Size(45, 17);
            this.RBNo.TabIndex = 4;
            this.RBNo.TabStop = true;
            this.RBNo.Text = "Non";
            this.RBNo.UseVisualStyleBackColor = true;
            this.RBNo.CheckedChanged += new System.EventHandler(this.RBNo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type :";
            // 
            // CBTypeExigences
            // 
            this.CBTypeExigences.FormattingEnabled = true;
            this.CBTypeExigences.Location = new System.Drawing.Point(108, 147);
            this.CBTypeExigences.Name = "CBTypeExigences";
            this.CBTypeExigences.Size = new System.Drawing.Size(250, 21);
            this.CBTypeExigences.TabIndex = 6;
            // 
            // BtnAddExigence
            // 
            this.BtnAddExigence.Location = new System.Drawing.Point(45, 177);
            this.BtnAddExigence.Name = "BtnAddExigence";
            this.BtnAddExigence.Size = new System.Drawing.Size(276, 38);
            this.BtnAddExigence.TabIndex = 7;
            this.BtnAddExigence.Text = "Créer l\'exigence";
            this.BtnAddExigence.UseVisualStyleBackColor = true;
            this.BtnAddExigence.Click += new System.EventHandler(this.BtnAddExigence_Click);
            // 
            // NewExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 227);
            this.Controls.Add(this.BtnAddExigence);
            this.Controls.Add(this.CBTypeExigences);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RBNo);
            this.Controls.Add(this.RBYes);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TBDescription;
        private System.Windows.Forms.RadioButton RBYes;
        private System.Windows.Forms.RadioButton RBNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBTypeExigences;
        private System.Windows.Forms.Button BtnAddExigence;
    }
}