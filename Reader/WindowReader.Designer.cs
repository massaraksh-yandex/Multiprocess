namespace Reader
{
    partial class WindowReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowReader));
            this.statusLine = new System.Windows.Forms.TextBox();
            this.fileView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusLine
            // 
            this.statusLine.Location = new System.Drawing.Point(12, 12);
            this.statusLine.Name = "statusLine";
            this.statusLine.ReadOnly = true;
            this.statusLine.Size = new System.Drawing.Size(260, 20);
            this.statusLine.TabIndex = 0;
            // 
            // fileView
            // 
            this.fileView.Location = new System.Drawing.Point(12, 38);
            this.fileView.Multiline = true;
            this.fileView.Name = "fileView";
            this.fileView.Size = new System.Drawing.Size(260, 211);
            this.fileView.TabIndex = 1;
            // 
            // WindowReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fileView);
            this.Controls.Add(this.statusLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowReader";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusLine;
        private System.Windows.Forms.TextBox fileView;
    }
}