namespace GptLogFormGen
{
    partial class Form1
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
            this.txtNumRecords = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.chkIncludeUtils = new System.Windows.Forms.CheckBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumRecords
            // 
            this.txtNumRecords.Location = new System.Drawing.Point(158, 26);
            this.txtNumRecords.Name = "txtNumRecords";
            this.txtNumRecords.Size = new System.Drawing.Size(100, 20);
            this.txtNumRecords.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(158, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(158, 102);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(200, 20);
            this.txtLink.TabIndex = 2;
            // 
            // chkIncludeUtils
            // 
            this.chkIncludeUtils.AutoSize = true;
            this.chkIncludeUtils.Location = new System.Drawing.Point(158, 141);
            this.chkIncludeUtils.Name = "chkIncludeUtils";
            this.chkIncludeUtils.Size = new System.Drawing.Size(85, 17);
            this.chkIncludeUtils.TabIndex = 3;
            this.chkIncludeUtils.Text = "Include Utils";
            this.chkIncludeUtils.UseVisualStyleBackColor = true;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(158, 174);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(100, 23);
            this.btnCreateFile.TabIndex = 4;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.AutoSize = true;
            this.lblNumRecords.Location = new System.Drawing.Point(26, 29);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(115, 13);
            this.lblNumRecords.TabIndex = 5;
            this.lblNumRecords.Text = "Number of Interactions:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Conversation Title:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(26, 105);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(80, 13);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Conversation Link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNumRecords);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.chkIncludeUtils);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtNumRecords);
            this.Name = "Form1";
            this.Text = "GptLogFormGen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNumRecords;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.CheckBox chkIncludeUtils;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLink;
    }
}
