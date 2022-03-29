
namespace CustomerViewer
{
    partial class formCustomerViewer
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
            this.labelIdentificationNumber = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxIdentificationNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.checkBoxVip = new System.Windows.Forms.CheckBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdentificationNumber
            // 
            this.labelIdentificationNumber.Location = new System.Drawing.Point(33, 26);
            this.labelIdentificationNumber.Name = "labelIdentificationNumber";
            this.labelIdentificationNumber.Size = new System.Drawing.Size(131, 15);
            this.labelIdentificationNumber.TabIndex = 0;
            this.labelIdentificationNumber.Text = "&ID:";
            this.labelIdentificationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(33, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(131, 15);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "&Title:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(33, 83);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(131, 15);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "&First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(33, 112);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(131, 15);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "&Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIdentificationNumber
            // 
            this.textBoxIdentificationNumber.Location = new System.Drawing.Point(170, 24);
            this.textBoxIdentificationNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdentificationNumber.Name = "textBoxIdentificationNumber";
            this.textBoxIdentificationNumber.ReadOnly = true;
            this.textBoxIdentificationNumber.Size = new System.Drawing.Size(132, 23);
            this.textBoxIdentificationNumber.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxIdentificationNumber, "Displays the customer\'s identification number");
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(170, 81);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 23);
            this.textBoxFirstName.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxFirstName, "Displays the customer\'s first name");
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(170, 110);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(132, 23);
            this.textBoxLastName.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxLastName, "Displays the customer\'s last name");
            // 
            // checkBoxVip
            // 
            this.checkBoxVip.AutoSize = true;
            this.checkBoxVip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVip.Enabled = false;
            this.checkBoxVip.Location = new System.Drawing.Point(136, 139);
            this.checkBoxVip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxVip.Name = "checkBoxVip";
            this.checkBoxVip.Size = new System.Drawing.Size(46, 19);
            this.checkBoxVip.TabIndex = 8;
            this.checkBoxVip.Text = "&VIP:";
            this.toolTip.SetToolTip(this.checkBoxVip, "Checked if the customer is a VIP");
            this.checkBoxVip.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Location = new System.Drawing.Point(21, 188);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(82, 22);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.Text = "&Previous";
            this.toolTip.SetToolTip(this.buttonPrevious, "Click to view the previous customer");
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.PreviousButton);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(126, 188);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 22);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitButton);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(231, 188);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(82, 22);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "&Next";
            this.toolTip.SetToolTip(this.buttonNext, "Click to view the next customer");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.NextButton);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(62, 224);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(82, 22);
            this.buttonFirst.TabIndex = 13;
            this.buttonFirst.Text = "Fi&rst";
            this.toolTip.SetToolTip(this.buttonFirst, "Click to view the first customer");
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.FirstButton);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(190, 224);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(82, 22);
            this.buttonLast.TabIndex = 14;
            this.buttonLast.Text = "L&ast";
            this.toolTip.SetToolTip(this.buttonLast, "Click to view the last customer");
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.LastButton);
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.Enabled = false;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "",
            "Dr.",
            "Duchess",
            "Duke",
            "Hon.",
            "Lady",
            "Lord",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Mx.",
            "Sir"});
            this.comboBoxTitle.Location = new System.Drawing.Point(169, 52);
            this.comboBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(133, 23);
            this.comboBoxTitle.TabIndex = 3;
            this.toolTip.SetToolTip(this.comboBoxTitle, "Displays the customer\'s title");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV Files|*.csv|Text Files|*.txt";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formCustomerViewer
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(334, 265);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.checkBoxVip);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxIdentificationNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelIdentificationNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCustomerViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Viewer";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentificationNumber;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxIdentificationNumber;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxVip;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
    }
}

