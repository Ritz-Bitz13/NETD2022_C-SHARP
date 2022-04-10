
namespace Lab03_Cases_Region
{
    partial class frmRegionCases
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
            this.lblCases = new System.Windows.Forms.Label();
            this.txtCases = new System.Windows.Forms.TextBox();
            this.lblRegion1 = new System.Windows.Forms.Label();
            this.lbxRegion1 = new System.Windows.Forms.ListBox();
            this.lbxRegion2 = new System.Windows.Forms.ListBox();
            this.lblRegion2 = new System.Windows.Forms.Label();
            this.lbxRegion3 = new System.Windows.Forms.ListBox();
            this.lblRegion3 = new System.Windows.Forms.Label();
            this.lblAverage1 = new System.Windows.Forms.Label();
            this.lblAverage2 = new System.Windows.Forms.Label();
            this.lblAverage3 = new System.Windows.Forms.Label();
            this.lblTotalAverage = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(27, 28);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(40, 15);
            this.lblCases.TabIndex = 0;
            this.lblCases.Text = "&Cases:";
            // 
            // txtCases
            // 
            this.txtCases.Location = new System.Drawing.Point(73, 25);
            this.txtCases.MaxLength = 9;
            this.txtCases.Name = "txtCases";
            this.txtCases.Size = new System.Drawing.Size(100, 23);
            this.txtCases.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCases, "Enter Cases here");
            // 
            // lblRegion1
            // 
            this.lblRegion1.AutoSize = true;
            this.lblRegion1.Location = new System.Drawing.Point(57, 82);
            this.lblRegion1.Name = "lblRegion1";
            this.lblRegion1.Size = new System.Drawing.Size(56, 15);
            this.lblRegion1.TabIndex = 2;
            this.lblRegion1.Text = "Region &1:";
            this.toolTip1.SetToolTip(this.lblRegion1, "Region 1");
            // 
            // lbxRegion1
            // 
            this.lbxRegion1.FormattingEnabled = true;
            this.lbxRegion1.ItemHeight = 15;
            this.lbxRegion1.Location = new System.Drawing.Point(35, 105);
            this.lbxRegion1.Name = "lbxRegion1";
            this.lbxRegion1.Size = new System.Drawing.Size(100, 199);
            this.lbxRegion1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lbxRegion1, "Region 1 List of cases");
            // 
            // lbxRegion2
            // 
            this.lbxRegion2.FormattingEnabled = true;
            this.lbxRegion2.ItemHeight = 15;
            this.lbxRegion2.Location = new System.Drawing.Point(177, 105);
            this.lbxRegion2.Name = "lbxRegion2";
            this.lbxRegion2.Size = new System.Drawing.Size(100, 199);
            this.lbxRegion2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.lbxRegion2, "Region 2 List of Cases");
            // 
            // lblRegion2
            // 
            this.lblRegion2.AutoSize = true;
            this.lblRegion2.Location = new System.Drawing.Point(199, 82);
            this.lblRegion2.Name = "lblRegion2";
            this.lblRegion2.Size = new System.Drawing.Size(56, 15);
            this.lblRegion2.TabIndex = 4;
            this.lblRegion2.Text = "Region &2:";
            this.toolTip1.SetToolTip(this.lblRegion2, "Region 2");
            // 
            // lbxRegion3
            // 
            this.lbxRegion3.FormattingEnabled = true;
            this.lbxRegion3.ItemHeight = 15;
            this.lbxRegion3.Location = new System.Drawing.Point(319, 105);
            this.lbxRegion3.Name = "lbxRegion3";
            this.lbxRegion3.Size = new System.Drawing.Size(100, 199);
            this.lbxRegion3.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lbxRegion3, "Region 3 list of cases");
            // 
            // lblRegion3
            // 
            this.lblRegion3.AutoSize = true;
            this.lblRegion3.Location = new System.Drawing.Point(341, 82);
            this.lblRegion3.Name = "lblRegion3";
            this.lblRegion3.Size = new System.Drawing.Size(56, 15);
            this.lblRegion3.TabIndex = 6;
            this.lblRegion3.Text = "Region &3:";
            this.toolTip1.SetToolTip(this.lblRegion3, "Region 3");
            // 
            // lblAverage1
            // 
            this.lblAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage1.Location = new System.Drawing.Point(28, 325);
            this.lblAverage1.Name = "lblAverage1";
            this.lblAverage1.Size = new System.Drawing.Size(115, 23);
            this.lblAverage1.TabIndex = 8;
            this.lblAverage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblAverage1, "Average of Region 1");
            // 
            // lblAverage2
            // 
            this.lblAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage2.Location = new System.Drawing.Point(169, 325);
            this.lblAverage2.Name = "lblAverage2";
            this.lblAverage2.Size = new System.Drawing.Size(115, 23);
            this.lblAverage2.TabIndex = 9;
            this.lblAverage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblAverage2, "Average of Region 2");
            // 
            // lblAverage3
            // 
            this.lblAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage3.Location = new System.Drawing.Point(310, 325);
            this.lblAverage3.Name = "lblAverage3";
            this.lblAverage3.Size = new System.Drawing.Size(115, 23);
            this.lblAverage3.TabIndex = 10;
            this.lblAverage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblAverage3, "Average of Region 3");
            // 
            // lblTotalAverage
            // 
            this.lblTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAverage.Location = new System.Drawing.Point(28, 362);
            this.lblTotalAverage.Name = "lblTotalAverage";
            this.lblTotalAverage.Size = new System.Drawing.Size(397, 23);
            this.lblTotalAverage.TabIndex = 11;
            this.lblTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTotalAverage, "Average of all Regions");
            this.lblTotalAverage.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(27, 410);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(130, 23);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Enter the case number to the region");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(163, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Re&set";
            this.toolTip1.SetToolTip(this.btnReset, "Reset all the Case numbers");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(302, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the Program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRegionCases
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(454, 460);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblTotalAverage);
            this.Controls.Add(this.lblAverage3);
            this.Controls.Add(this.lblAverage2);
            this.Controls.Add(this.lblAverage1);
            this.Controls.Add(this.lbxRegion3);
            this.Controls.Add(this.lblRegion3);
            this.Controls.Add(this.lbxRegion2);
            this.Controls.Add(this.lblRegion2);
            this.Controls.Add(this.lbxRegion1);
            this.Controls.Add(this.lblRegion1);
            this.Controls.Add(this.txtCases);
            this.Controls.Add(this.lblCases);
            this.MaximumSize = new System.Drawing.Size(470, 499);
            this.MinimumSize = new System.Drawing.Size(470, 499);
            this.Name = "frmRegionCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases by Region";
            this.Load += new System.EventHandler(this.frmRegionCases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.TextBox txtCases;
        private System.Windows.Forms.Label lblRegion1;
        private System.Windows.Forms.ListBox lbxRegion1;
        private System.Windows.Forms.ListBox lbxRegion2;
        private System.Windows.Forms.Label lblRegion2;
        private System.Windows.Forms.ListBox lbxRegion3;
        private System.Windows.Forms.Label lblRegion3;
        private System.Windows.Forms.Label lblAverage1;
        private System.Windows.Forms.Label lblAverage2;
        private System.Windows.Forms.Label lblAverage3;
        private System.Windows.Forms.Label lblTotalAverage;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

