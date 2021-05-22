namespace ImageToTextConverter
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
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.BrowseAllFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(155, 37);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(476, 26);
            this.filePathTxt.TabIndex = 4;
            // 
            // BrowseAllFiles
            // 
            this.BrowseAllFiles.Location = new System.Drawing.Point(661, 24);
            this.BrowseAllFiles.Name = "BrowseAllFiles";
            this.BrowseAllFiles.Size = new System.Drawing.Size(155, 39);
            this.BrowseAllFiles.TabIndex = 1;
            this.BrowseAllFiles.Text = "BrowseAllFiles";
            this.BrowseAllFiles.UseVisualStyleBackColor = true;
            this.BrowseAllFiles.Click += new System.EventHandler(this.BrowseAllFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Files";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(264, 106);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(176, 39);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "ConvertImageToText";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 185);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseAllFiles);
            this.Controls.Add(this.filePathTxt);
            this.Name = "Form1";
            this.Text = "ImageToTextConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button BrowseAllFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConvertButton;
    }
}

