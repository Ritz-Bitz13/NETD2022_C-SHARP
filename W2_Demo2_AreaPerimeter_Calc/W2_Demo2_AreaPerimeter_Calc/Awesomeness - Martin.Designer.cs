
namespace W2_Demo2_AreaPerimeter_Calc
{
    partial class Form1
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
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.TextBox();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.textPerimeter = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
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
            this.labelTitle.Size = new System.Drawing.Size(278, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Area and Perimeter Calculator";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(108, 73);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(44, 15);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "&Length";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(108, 102);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(39, 15);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "&Width";
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(191, 73);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(100, 23);
            this.textLength.TabIndex = 2;
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(191, 102);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(100, 23);
            this.textWidth.TabIndex = 4;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(108, 169);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(31, 15);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Area";
            // 
            // textArea
            // 
            this.textArea.Enabled = false;
            this.textArea.Location = new System.Drawing.Point(191, 169);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(100, 23);
            this.textArea.TabIndex = 7;
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(108, 198);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(58, 15);
            this.labelPerimeter.TabIndex = 8;
            this.labelPerimeter.Text = "Perimeter";
            // 
            // textPerimeter
            // 
            this.textPerimeter.Enabled = false;
            this.textPerimeter.Location = new System.Drawing.Point(191, 198);
            this.textPerimeter.Name = "textPerimeter";
            this.textPerimeter.Size = new System.Drawing.Size(100, 23);
            this.textPerimeter.TabIndex = 9;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(191, 131);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(202, 242);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(283, 242);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(381, 289);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textPerimeter);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area and Perimeter Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.TextBox textPerimeter;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

