
namespace Week09_Multiforms
{
    partial class frmAbout
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
            this.lblAboutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAboutLabel
            // 
            this.lblAboutLabel.Location = new System.Drawing.Point(12, 9);
            this.lblAboutLabel.Name = "lblAboutLabel";
            this.lblAboutLabel.Size = new System.Drawing.Size(314, 68);
            this.lblAboutLabel.TabIndex = 0;
            this.lblAboutLabel.Text = "This Project was a demo that showed us how to make a\r\ndata graph with generic lis" +
    "ts then about opening multiple\r\nforms and data back and forth";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author: Martin Barber\r\nStudent ID: 100368442\r\nDate: March 15th, 2021\r\nTitle: Week" +
    " 09 - Class Demo";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 212);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAboutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Trooper Factory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAboutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}