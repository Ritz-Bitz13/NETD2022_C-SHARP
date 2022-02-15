
namespace Lab_1_Cases
{
    partial class frmCases
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
            this.components = new System.ComponentModel.Container();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblAverageCases = new System.Windows.Forms.Label();
            this.txtCases = new System.Windows.Forms.TextBox();
            this.lblCases = new System.Windows.Forms.Label();
            this.lbxWeeklyCases = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(247, 38);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(72, 15);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Day: Sunday";
            this.toolTip1.SetToolTip(this.lblDay, "The day of the week");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(257, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Re&set";
            this.toolTip1.SetToolTip(this.btnReset, "Reset button will reset everything to default (startup)");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(36, 372);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Enter button will enter the cases to the listBox");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblAverageCases
            // 
            this.lblAverageCases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageCases.Location = new System.Drawing.Point(36, 325);
            this.lblAverageCases.Name = "lblAverageCases";
            this.lblAverageCases.Size = new System.Drawing.Size(296, 23);
            this.lblAverageCases.TabIndex = 4;
            this.lblAverageCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblAverageCases, "End of the week average case numbers");
            // 
            // txtCases
            // 
            this.txtCases.Location = new System.Drawing.Point(82, 35);
            this.txtCases.Name = "txtCases";
            this.txtCases.Size = new System.Drawing.Size(103, 23);
            this.txtCases.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCases, "Enter Case Numbers here");
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(36, 38);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(40, 15);
            this.lblCases.TabIndex = 1;
            this.lblCases.Text = "&Cases:";
            // 
            // lbxWeeklyCases
            // 
            this.lbxWeeklyCases.FormattingEnabled = true;
            this.lbxWeeklyCases.ItemHeight = 15;
            this.lbxWeeklyCases.Location = new System.Drawing.Point(36, 92);
            this.lbxWeeklyCases.Name = "lbxWeeklyCases";
            this.lbxWeeklyCases.Size = new System.Drawing.Size(296, 214);
            this.lbxWeeklyCases.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lbxWeeklyCases, "Previous Days case numbers");
            // 
            // frmCases
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lbxWeeklyCases);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblAverageCases);
            this.Controls.Add(this.txtCases);
            this.Controls.Add(this.lblCases);
            this.MaximumSize = new System.Drawing.Size(396, 489);
            this.MinimumSize = new System.Drawing.Size(396, 489);
            this.Name = "frmCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblAverageCases;
        private System.Windows.Forms.TextBox txtCases;
        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.ListBox lbxWeeklyCases;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

