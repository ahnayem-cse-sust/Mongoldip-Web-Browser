namespace Mongoldip_Web_Browser
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
            this.urlButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // urlButton
            // 
            this.urlButton.Location = new System.Drawing.Point(327, 12);
            this.urlButton.Name = "urlButton";
            this.urlButton.Size = new System.Drawing.Size(75, 23);
            this.urlButton.TabIndex = 0;
            this.urlButton.Text = "Enter";
            this.urlButton.UseVisualStyleBackColor = true;
            this.urlButton.Click += new System.EventHandler(this.urlButton_Click);
            this.urlButton.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(28, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(636, 363);
            this.webBrowser1.TabIndex = 1;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(28, 14);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(293, 20);
            this.urlBox.TabIndex = 2;
            this.urlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(691, 446);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.urlButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Mongoldip Web Browser";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urlButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox urlBox;
    }
}

