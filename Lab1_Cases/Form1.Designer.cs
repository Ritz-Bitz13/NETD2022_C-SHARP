
namespace Lab1_Case
{
    partial class frmWeeklyCases
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCases = new System.Windows.Forms.Label();
            this.txtcasesCount = new System.Windows.Forms.TextBox();
            this.lbxWeeklyCases = new System.Windows.Forms.ListBox();
            this.lblAverageCases = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(46, 50);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(40, 15);
            this.lblCases.TabIndex = 0;
            this.lblCases.Text = "&Cases:";
            // 
            // txtcasesCount
            // 
            this.txtcasesCount.Location = new System.Drawing.Point(92, 47);
            this.txtcasesCount.Name = "txtcasesCount";
            this.txtcasesCount.Size = new System.Drawing.Size(103, 23);
            this.txtcasesCount.TabIndex = 1;
            // 
            // lbxWeeklyCases
            // 
            this.lbxWeeklyCases.FormattingEnabled = true;
            this.lbxWeeklyCases.ItemHeight = 15;
            this.lbxWeeklyCases.Location = new System.Drawing.Point(46, 116);
            this.lbxWeeklyCases.Name = "lbxWeeklyCases";
            this.lbxWeeklyCases.Size = new System.Drawing.Size(296, 199);
            this.lbxWeeklyCases.TabIndex = 2;
            // 
            // lblAverageCases
            // 
            this.lblAverageCases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageCases.Location = new System.Drawing.Point(46, 337);
            this.lblAverageCases.Name = "lblAverageCases";
            this.lblAverageCases.Size = new System.Drawing.Size(296, 23);
            this.lblAverageCases.TabIndex = 3;
            this.lblAverageCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(46, 384);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(155, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Re&set";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(257, 50);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(0, 15);
            this.lblDay.TabIndex = 7;
            // 
            // frmWeeklyCases
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(381, 443);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblAverageCases);
            this.Controls.Add(this.lbxWeeklyCases);
            this.Controls.Add(this.txtcasesCount);
            this.Controls.Add(this.lblCases);
            this.MaximumSize = new System.Drawing.Size(397, 482);
            this.MinimumSize = new System.Drawing.Size(397, 482);
            this.Name = "frmWeeklyCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.TextBox txtcasesCount;
        private System.Windows.Forms.ListBox lbxWeeklyCases;
        private System.Windows.Forms.Label lblAverageCases;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDay;
    }
}

