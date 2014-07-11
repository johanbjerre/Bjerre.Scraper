namespace Bjerre.Scraper.TestApp
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
            this.runkeeperTest = new System.Windows.Forms.Button();
            this._log = new System.Windows.Forms.RichTextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Runkeeper = new System.Windows.Forms.Label();
            this.Scrape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runkeeperTest
            // 
            this.runkeeperTest.Location = new System.Drawing.Point(12, 247);
            this.runkeeperTest.Name = "runkeeperTest";
            this.runkeeperTest.Size = new System.Drawing.Size(100, 23);
            this.runkeeperTest.TabIndex = 0;
            this.runkeeperTest.Text = "runkeeperTest";
            this.runkeeperTest.UseVisualStyleBackColor = true;
            this.runkeeperTest.Click += new System.EventHandler(this.runkeeperTest_Click);
            // 
            // _log
            // 
            this._log.Location = new System.Drawing.Point(128, 14);
            this._log.Name = "_log";
            this._log.Size = new System.Drawing.Size(1086, 500);
            this._log.TabIndex = 1;
            this._log.Text = "";
            this._log.TextChanged += new System.EventHandler(this._log_TextChanged);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(12, 14);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(110, 20);
            this.urlBox.TabIndex = 2;
            this.urlBox.Text = "http://www.di.se";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(12, 199);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(100, 20);
            this.userNameBox.TabIndex = 3;
            this.userNameBox.Text = "username";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 221);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.Text = "password";
            // 
            // Runkeeper
            // 
            this.Runkeeper.AutoSize = true;
            this.Runkeeper.Location = new System.Drawing.Point(13, 183);
            this.Runkeeper.Name = "Runkeeper";
            this.Runkeeper.Size = new System.Drawing.Size(60, 13);
            this.Runkeeper.TabIndex = 5;
            this.Runkeeper.Text = "Runkeeper";
            // 
            // Scrape
            // 
            this.Scrape.Location = new System.Drawing.Point(12, 40);
            this.Scrape.Name = "Scrape";
            this.Scrape.Size = new System.Drawing.Size(110, 23);
            this.Scrape.TabIndex = 6;
            this.Scrape.Text = "Scrape";
            this.Scrape.UseVisualStyleBackColor = true;
            this.Scrape.Click += new System.EventHandler(this.Scrape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 526);
            this.Controls.Add(this.Scrape);
            this.Controls.Add(this.Runkeeper);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this._log);
            this.Controls.Add(this.runkeeperTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runkeeperTest;
        private System.Windows.Forms.RichTextBox _log;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label Runkeeper;
        private System.Windows.Forms.Button Scrape;
    }
}

