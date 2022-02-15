
namespace ICE2_DiseaseCases
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
            this.components = new System.ComponentModel.Container();
            this.lblWeekDays = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.txtDay1 = new System.Windows.Forms.TextBox();
            this.txtDay2 = new System.Windows.Forms.TextBox();
            this.txtDay3 = new System.Windows.Forms.TextBox();
            this.txtDay4 = new System.Windows.Forms.TextBox();
            this.txtDay5 = new System.Windows.Forms.TextBox();
            this.txtDay6 = new System.Windows.Forms.TextBox();
            this.txtDay7 = new System.Windows.Forms.TextBox();
            this.lblInfectionsTitle = new System.Windows.Forms.Label();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDailyAverageLabel = new System.Windows.Forms.Label();
            this.lblDailyAverage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblWeekDays
            // 
            this.lblWeekDays.AutoSize = true;
            this.lblWeekDays.Location = new System.Drawing.Point(79, 99);
            this.lblWeekDays.Name = "lblWeekDays";
            this.lblWeekDays.Size = new System.Drawing.Size(60, 15);
            this.lblWeekDays.TabIndex = 3;
            this.lblWeekDays.Text = "Weekdays";
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Location = new System.Drawing.Point(79, 131);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(38, 15);
            this.lblDay1.TabIndex = 4;
            this.lblDay1.Text = "label1";
            this.toolTip1.SetToolTip(this.lblDay1, "Day 1");
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Location = new System.Drawing.Point(79, 161);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(38, 15);
            this.lblDay2.TabIndex = 5;
            this.lblDay2.Text = "label2";
            this.toolTip1.SetToolTip(this.lblDay2, "Day 2");
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Location = new System.Drawing.Point(79, 191);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(38, 15);
            this.lblDay3.TabIndex = 6;
            this.lblDay3.Text = "label3";
            this.toolTip1.SetToolTip(this.lblDay3, "Day 3");
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Location = new System.Drawing.Point(79, 221);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(38, 15);
            this.lblDay4.TabIndex = 7;
            this.lblDay4.Text = "label4";
            this.toolTip1.SetToolTip(this.lblDay4, "Day 4");
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Location = new System.Drawing.Point(79, 254);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(38, 15);
            this.lblDay5.TabIndex = 8;
            this.lblDay5.Text = "label5";
            this.toolTip1.SetToolTip(this.lblDay5, "Day 5");
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Location = new System.Drawing.Point(79, 284);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(38, 15);
            this.lblDay6.TabIndex = 9;
            this.lblDay6.Text = "label6";
            this.toolTip1.SetToolTip(this.lblDay6, "Day 6");
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Location = new System.Drawing.Point(79, 314);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(38, 15);
            this.lblDay7.TabIndex = 10;
            this.lblDay7.Text = "label7";
            this.toolTip1.SetToolTip(this.lblDay7, "Day 7");
            // 
            // txtDay1
            // 
            this.txtDay1.Location = new System.Drawing.Point(171, 128);
            this.txtDay1.MaxLength = 4;
            this.txtDay1.Name = "txtDay1";
            this.txtDay1.Size = new System.Drawing.Size(59, 23);
            this.txtDay1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtDay1, "Day 1 Case numbers");
            // 
            // txtDay2
            // 
            this.txtDay2.Location = new System.Drawing.Point(171, 158);
            this.txtDay2.MaxLength = 4;
            this.txtDay2.Name = "txtDay2";
            this.txtDay2.Size = new System.Drawing.Size(59, 23);
            this.txtDay2.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtDay2, "Day 2 Case numbers");
            // 
            // txtDay3
            // 
            this.txtDay3.Location = new System.Drawing.Point(171, 188);
            this.txtDay3.MaxLength = 4;
            this.txtDay3.Name = "txtDay3";
            this.txtDay3.Size = new System.Drawing.Size(59, 23);
            this.txtDay3.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtDay3, "Day 3 Case numbers");
            // 
            // txtDay4
            // 
            this.txtDay4.Location = new System.Drawing.Point(171, 218);
            this.txtDay4.MaxLength = 4;
            this.txtDay4.Name = "txtDay4";
            this.txtDay4.Size = new System.Drawing.Size(59, 23);
            this.txtDay4.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtDay4, "Day 4 Case numbers");
            // 
            // txtDay5
            // 
            this.txtDay5.Location = new System.Drawing.Point(171, 251);
            this.txtDay5.MaxLength = 4;
            this.txtDay5.Name = "txtDay5";
            this.txtDay5.Size = new System.Drawing.Size(59, 23);
            this.txtDay5.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtDay5, "Day 5 Case numbers");
            // 
            // txtDay6
            // 
            this.txtDay6.Location = new System.Drawing.Point(171, 281);
            this.txtDay6.MaxLength = 4;
            this.txtDay6.Name = "txtDay6";
            this.txtDay6.Size = new System.Drawing.Size(59, 23);
            this.txtDay6.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtDay6, "Day 6 Case numbers");
            // 
            // txtDay7
            // 
            this.txtDay7.Location = new System.Drawing.Point(171, 311);
            this.txtDay7.MaxLength = 4;
            this.txtDay7.Name = "txtDay7";
            this.txtDay7.Size = new System.Drawing.Size(59, 23);
            this.txtDay7.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtDay7, "Day 7 Case numbers");
            // 
            // lblInfectionsTitle
            // 
            this.lblInfectionsTitle.AutoSize = true;
            this.lblInfectionsTitle.Location = new System.Drawing.Point(171, 99);
            this.lblInfectionsTitle.Name = "lblInfectionsTitle";
            this.lblInfectionsTitle.Size = new System.Drawing.Size(59, 15);
            this.lblInfectionsTitle.TabIndex = 11;
            this.lblInfectionsTitle.Text = "Infections";
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(79, 50);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartingDate.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtpStartingDate, "Date selected");
            this.dtpStartingDate.ValueChanged += new System.EventHandler(this.dtpStartingDate_ValueChanged);
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Location = new System.Drawing.Point(79, 29);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(75, 15);
            this.lblStartingDate.TabIndex = 1;
            this.lblStartingDate.Text = "Starting Date";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(79, 390);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 48);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate Average";
            this.toolTip1.SetToolTip(this.btnCalculate, "Calculate the Average");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDailyAverageLabel
            // 
            this.lblDailyAverageLabel.AutoSize = true;
            this.lblDailyAverageLabel.Location = new System.Drawing.Point(79, 354);
            this.lblDailyAverageLabel.Name = "lblDailyAverageLabel";
            this.lblDailyAverageLabel.Size = new System.Drawing.Size(79, 15);
            this.lblDailyAverageLabel.TabIndex = 19;
            this.lblDailyAverageLabel.Text = "Daily Average";
            this.toolTip1.SetToolTip(this.lblDailyAverageLabel, "Daily Average");
            // 
            // lblDailyAverage
            // 
            this.lblDailyAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDailyAverage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDailyAverage.Location = new System.Drawing.Point(171, 348);
            this.lblDailyAverage.Name = "lblDailyAverage";
            this.lblDailyAverage.Size = new System.Drawing.Size(59, 29);
            this.lblDailyAverage.TabIndex = 20;
            this.lblDailyAverage.Text = "0";
            this.toolTip1.SetToolTip(this.lblDailyAverage, "Average over the week");
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(160, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 48);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset to Default settings");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 48);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Close the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWeeklyCases
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDailyAverage);
            this.Controls.Add(this.lblDailyAverageLabel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.dtpStartingDate);
            this.Controls.Add(this.lblInfectionsTitle);
            this.Controls.Add(this.txtDay7);
            this.Controls.Add(this.txtDay6);
            this.Controls.Add(this.txtDay5);
            this.Controls.Add(this.txtDay4);
            this.Controls.Add(this.txtDay3);
            this.Controls.Add(this.txtDay2);
            this.Controls.Add(this.txtDay1);
            this.Controls.Add(this.lblDay7);
            this.Controls.Add(this.lblDay6);
            this.Controls.Add(this.lblDay5);
            this.Controls.Add(this.lblDay4);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.lblDay1);
            this.Controls.Add(this.lblWeekDays);
            this.MaximumSize = new System.Drawing.Size(399, 489);
            this.MinimumSize = new System.Drawing.Size(399, 489);
            this.Name = "frmWeeklyCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Cases";
            this.toolTip1.SetToolTip(this, "Weekly Case Calculating Average");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeekDays;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.Label lblDay7;
        private System.Windows.Forms.TextBox txtDay1;
        private System.Windows.Forms.TextBox txtDay2;
        private System.Windows.Forms.TextBox txtDay3;
        private System.Windows.Forms.TextBox txtDay4;
        private System.Windows.Forms.TextBox txtDay5;
        private System.Windows.Forms.TextBox txtDay6;
        private System.Windows.Forms.TextBox txtDay7;
        private System.Windows.Forms.Label lblInfectionsTitle;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDailyAverageLabel;
        private System.Windows.Forms.Label lblDailyAverage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

