
namespace Lab02_Semester_Grades
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.lblGradeResult1 = new System.Windows.Forms.Label();
            this.lblGradeResult2 = new System.Windows.Forms.Label();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblGradeResult4 = new System.Windows.Forms.Label();
            this.txtGrade4 = new System.Windows.Forms.TextBox();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblGradeResult3 = new System.Windows.Forms.Label();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblGradeResult5 = new System.Windows.Forms.Label();
            this.txtGrade5 = new System.Windows.Forms.TextBox();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.lblGradeResult6 = new System.Windows.Forms.Label();
            this.txtGrade6 = new System.Windows.Forms.TextBox();
            this.lblCourse6 = new System.Windows.Forms.Label();
            this.lblGradeResult7 = new System.Windows.Forms.Label();
            this.txtGrade7 = new System.Windows.Forms.TextBox();
            this.lblCourse7 = new System.Windows.Forms.Label();
            this.lblGradeResultSemester = new System.Windows.Forms.Label();
            this.txtSemesterAverage = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblProblems = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Location = new System.Drawing.Point(40, 18);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(56, 15);
            this.lblCourse1.TabIndex = 0;
            this.lblCourse1.Text = "Course &1:";
            this.toolTip1.SetToolTip(this.lblCourse1, "Course 1");
            // 
            // txtGrade1
            // 
            this.txtGrade1.Location = new System.Drawing.Point(110, 15);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(71, 23);
            this.txtGrade1.TabIndex = 1;
            this.txtGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade1, "Enter Course 1 Grade here");
            this.txtGrade1.Leave += new System.EventHandler(this.txtGrade1_Leave);
            // 
            // lblGradeResult1
            // 
            this.lblGradeResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult1.Location = new System.Drawing.Point(210, 15);
            this.lblGradeResult1.Name = "lblGradeResult1";
            this.lblGradeResult1.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult1.TabIndex = 2;
            this.lblGradeResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult1, "Course 1 grade letter");
            // 
            // lblGradeResult2
            // 
            this.lblGradeResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult2.Location = new System.Drawing.Point(210, 60);
            this.lblGradeResult2.Name = "lblGradeResult2";
            this.lblGradeResult2.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult2.TabIndex = 5;
            this.lblGradeResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult2, "Course 2 grade letter");
            // 
            // txtGrade2
            // 
            this.txtGrade2.Location = new System.Drawing.Point(110, 60);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(71, 23);
            this.txtGrade2.TabIndex = 4;
            this.txtGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade2, "Enter Course 2 Grade here");
            this.txtGrade2.Leave += new System.EventHandler(this.txtGrade2_Leave);
            // 
            // lblCourse2
            // 
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.Location = new System.Drawing.Point(40, 63);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(56, 15);
            this.lblCourse2.TabIndex = 3;
            this.lblCourse2.Text = "Course &2:";
            this.toolTip1.SetToolTip(this.lblCourse2, "Course 2");
            // 
            // lblGradeResult4
            // 
            this.lblGradeResult4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult4.Location = new System.Drawing.Point(210, 150);
            this.lblGradeResult4.Name = "lblGradeResult4";
            this.lblGradeResult4.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult4.TabIndex = 11;
            this.lblGradeResult4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult4, "Course 4 grade letter");
            // 
            // txtGrade4
            // 
            this.txtGrade4.Location = new System.Drawing.Point(110, 150);
            this.txtGrade4.Name = "txtGrade4";
            this.txtGrade4.Size = new System.Drawing.Size(71, 23);
            this.txtGrade4.TabIndex = 10;
            this.txtGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade4, "Enter Course 4 Grade here");
            this.txtGrade4.Leave += new System.EventHandler(this.txtGrade4_Leave);
            // 
            // lblCourse4
            // 
            this.lblCourse4.AutoSize = true;
            this.lblCourse4.Location = new System.Drawing.Point(40, 153);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(56, 15);
            this.lblCourse4.TabIndex = 9;
            this.lblCourse4.Text = "Course &4:";
            this.toolTip1.SetToolTip(this.lblCourse4, "Course 4");
            // 
            // lblGradeResult3
            // 
            this.lblGradeResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult3.Location = new System.Drawing.Point(210, 105);
            this.lblGradeResult3.Name = "lblGradeResult3";
            this.lblGradeResult3.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult3.TabIndex = 8;
            this.lblGradeResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult3, "Course 3 grade letter");
            // 
            // txtGrade3
            // 
            this.txtGrade3.Location = new System.Drawing.Point(110, 105);
            this.txtGrade3.Name = "txtGrade3";
            this.txtGrade3.Size = new System.Drawing.Size(71, 23);
            this.txtGrade3.TabIndex = 7;
            this.txtGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade3, "Enter Course 3 Grade here");
            this.txtGrade3.Leave += new System.EventHandler(this.txtGrade3_Leave);
            // 
            // lblCourse3
            // 
            this.lblCourse3.AutoSize = true;
            this.lblCourse3.Location = new System.Drawing.Point(40, 108);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(56, 15);
            this.lblCourse3.TabIndex = 6;
            this.lblCourse3.Text = "Course &3:";
            this.toolTip1.SetToolTip(this.lblCourse3, "Course 3");
            // 
            // lblGradeResult5
            // 
            this.lblGradeResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult5.Location = new System.Drawing.Point(210, 195);
            this.lblGradeResult5.Name = "lblGradeResult5";
            this.lblGradeResult5.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult5.TabIndex = 14;
            this.lblGradeResult5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult5, "Course 5 grade letter");
            // 
            // txtGrade5
            // 
            this.txtGrade5.Location = new System.Drawing.Point(110, 195);
            this.txtGrade5.Name = "txtGrade5";
            this.txtGrade5.Size = new System.Drawing.Size(71, 23);
            this.txtGrade5.TabIndex = 13;
            this.txtGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade5, "Enter Course 5 Grade here");
            this.txtGrade5.Leave += new System.EventHandler(this.txtGrade5_Leave);
            // 
            // lblCourse5
            // 
            this.lblCourse5.AutoSize = true;
            this.lblCourse5.Location = new System.Drawing.Point(40, 198);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(56, 15);
            this.lblCourse5.TabIndex = 12;
            this.lblCourse5.Text = "Course &5:";
            this.toolTip1.SetToolTip(this.lblCourse5, "Course 5");
            // 
            // lblGradeResult6
            // 
            this.lblGradeResult6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult6.Location = new System.Drawing.Point(210, 240);
            this.lblGradeResult6.Name = "lblGradeResult6";
            this.lblGradeResult6.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult6.TabIndex = 17;
            this.lblGradeResult6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult6, "Course 6 grade letter");
            // 
            // txtGrade6
            // 
            this.txtGrade6.Location = new System.Drawing.Point(110, 240);
            this.txtGrade6.Name = "txtGrade6";
            this.txtGrade6.Size = new System.Drawing.Size(71, 23);
            this.txtGrade6.TabIndex = 16;
            this.txtGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade6, "Enter Course 6 Grade here");
            this.txtGrade6.Leave += new System.EventHandler(this.txtGrade6_Leave);
            // 
            // lblCourse6
            // 
            this.lblCourse6.AutoSize = true;
            this.lblCourse6.Location = new System.Drawing.Point(40, 243);
            this.lblCourse6.Name = "lblCourse6";
            this.lblCourse6.Size = new System.Drawing.Size(56, 15);
            this.lblCourse6.TabIndex = 15;
            this.lblCourse6.Text = "Course &6:";
            this.toolTip1.SetToolTip(this.lblCourse6, "Course 6");
            // 
            // lblGradeResult7
            // 
            this.lblGradeResult7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResult7.Location = new System.Drawing.Point(210, 285);
            this.lblGradeResult7.Name = "lblGradeResult7";
            this.lblGradeResult7.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResult7.TabIndex = 20;
            this.lblGradeResult7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResult7, "Course 7 grade letter");
            // 
            // txtGrade7
            // 
            this.txtGrade7.Location = new System.Drawing.Point(110, 285);
            this.txtGrade7.Name = "txtGrade7";
            this.txtGrade7.Size = new System.Drawing.Size(71, 23);
            this.txtGrade7.TabIndex = 19;
            this.txtGrade7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrade7, "Enter Course 7 Grade here");
            this.txtGrade7.Leave += new System.EventHandler(this.txtGrade7_Leave);
            // 
            // lblCourse7
            // 
            this.lblCourse7.AutoSize = true;
            this.lblCourse7.Location = new System.Drawing.Point(40, 288);
            this.lblCourse7.Name = "lblCourse7";
            this.lblCourse7.Size = new System.Drawing.Size(56, 15);
            this.lblCourse7.TabIndex = 18;
            this.lblCourse7.Text = "Course &7:";
            this.toolTip1.SetToolTip(this.lblCourse7, "Course 7");
            // 
            // lblGradeResultSemester
            // 
            this.lblGradeResultSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGradeResultSemester.Location = new System.Drawing.Point(210, 329);
            this.lblGradeResultSemester.Name = "lblGradeResultSemester";
            this.lblGradeResultSemester.Size = new System.Drawing.Size(70, 23);
            this.lblGradeResultSemester.TabIndex = 23;
            this.lblGradeResultSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblGradeResultSemester, "Full semester Grade Letter");
            // 
            // txtSemesterAverage
            // 
            this.txtSemesterAverage.Location = new System.Drawing.Point(110, 330);
            this.txtSemesterAverage.Name = "txtSemesterAverage";
            this.txtSemesterAverage.ReadOnly = true;
            this.txtSemesterAverage.Size = new System.Drawing.Size(71, 23);
            this.txtSemesterAverage.TabIndex = 22;
            this.txtSemesterAverage.TabStop = false;
            this.txtSemesterAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtSemesterAverage, "This is your semester average");
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(40, 333);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(58, 15);
            this.lblSemester.TabIndex = 21;
            this.lblSemester.Text = "Semester:";
            this.toolTip1.SetToolTip(this.lblSemester, "Semester");
            // 
            // lblProblems
            // 
            this.lblProblems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProblems.Location = new System.Drawing.Point(40, 369);
            this.lblProblems.Name = "lblProblems";
            this.lblProblems.Size = new System.Drawing.Size(240, 63);
            this.lblProblems.TabIndex = 24;
            this.toolTip1.SetToolTip(this.lblProblems, "This will display any errors in the course grades textboxes");
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 451);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(69, 23);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "This will calculate the average");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(125, 451);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Re&set";
            this.toolTip1.SetToolTip(this.btnReset, "This will reset for forum");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(211, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 23);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "This will exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(322, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblProblems);
            this.Controls.Add(this.lblGradeResultSemester);
            this.Controls.Add(this.txtSemesterAverage);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblGradeResult7);
            this.Controls.Add(this.txtGrade7);
            this.Controls.Add(this.lblCourse7);
            this.Controls.Add(this.lblGradeResult6);
            this.Controls.Add(this.txtGrade6);
            this.Controls.Add(this.lblCourse6);
            this.Controls.Add(this.lblGradeResult5);
            this.Controls.Add(this.txtGrade5);
            this.Controls.Add(this.lblCourse5);
            this.Controls.Add(this.lblGradeResult4);
            this.Controls.Add(this.txtGrade4);
            this.Controls.Add(this.lblCourse4);
            this.Controls.Add(this.lblGradeResult3);
            this.Controls.Add(this.txtGrade3);
            this.Controls.Add(this.lblCourse3);
            this.Controls.Add(this.lblGradeResult2);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.lblCourse2);
            this.Controls.Add(this.lblGradeResult1);
            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.lblCourse1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(338, 526);
            this.MinimumSize = new System.Drawing.Size(338, 526);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Martin\'s Grade Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.Label lblGradeResult1;
        private System.Windows.Forms.Label lblGradeResult2;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblGradeResult4;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblGradeResult3;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblGradeResult5;
        private System.Windows.Forms.TextBox txtGrade5;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.Label lblGradeResult6;
        private System.Windows.Forms.TextBox txtGrade6;
        private System.Windows.Forms.Label lblCourse6;
        private System.Windows.Forms.Label lblGradeResult7;
        private System.Windows.Forms.TextBox txtGrade7;
        private System.Windows.Forms.Label lblCourse7;
        private System.Windows.Forms.Label lblGradeResultSemester;
        private System.Windows.Forms.TextBox txtSemesterAverage;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblProblems;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

