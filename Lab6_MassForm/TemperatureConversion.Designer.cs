
namespace Lab6_MassForm
{
    partial class frmTemperature
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInputTemp = new System.Windows.Forms.Label();
            this.textInputTemp = new System.Windows.Forms.TextBox();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.labelDegree = new System.Windows.Forms.Label();
            this.labelUnits = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(13, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(222, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Temperature Convertor";
            // 
            // labelInputTemp
            // 
            this.labelInputTemp.AutoSize = true;
            this.labelInputTemp.Location = new System.Drawing.Point(26, 62);
            this.labelInputTemp.Name = "labelInputTemp";
            this.labelInputTemp.Size = new System.Drawing.Size(104, 15);
            this.labelInputTemp.TabIndex = 1;
            this.labelInputTemp.Text = "&Input Temperature";
            // 
            // textInputTemp
            // 
            this.textInputTemp.Location = new System.Drawing.Point(26, 81);
            this.textInputTemp.Name = "textInputTemp";
            this.textInputTemp.Size = new System.Drawing.Size(100, 23);
            this.textInputTemp.TabIndex = 2;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Checked = true;
            this.radioC.Location = new System.Drawing.Point(143, 84);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(33, 19);
            this.radioC.TabIndex = 3;
            this.radioC.TabStop = true;
            this.radioC.Text = "&C";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(183, 84);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(31, 19);
            this.radioF.TabIndex = 4;
            this.radioF.TabStop = true;
            this.radioF.Text = "&F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(239, 81);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Con&vert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textAnswer
            // 
            this.textAnswer.Enabled = false;
            this.textAnswer.Location = new System.Drawing.Point(334, 81);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(61, 23);
            this.textAnswer.TabIndex = 6;
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Location = new System.Drawing.Point(395, 84);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(12, 15);
            this.labelDegree.TabIndex = 7;
            this.labelDegree.Text = "°";
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(402, 85);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(12, 15);
            this.labelUnits.TabIndex = 8;
            this.labelUnits.Text = "_";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(267, 122);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 51);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(348, 122);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 51);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "C&lose";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmTemperature
            // 
            this.AcceptButton = this.buttonConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(439, 191);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.radioF);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.textInputTemp);
            this.Controls.Add(this.labelInputTemp);
            this.Controls.Add(this.labelTitle);
            this.MaximumSize = new System.Drawing.Size(455, 230);
            this.MinimumSize = new System.Drawing.Size(455, 230);
            this.Name = "frmTemperature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Convertor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInputTemp;
        private System.Windows.Forms.TextBox textInputTemp;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

