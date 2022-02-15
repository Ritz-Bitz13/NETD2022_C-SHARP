
namespace Week03_DemoA_Main
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddColour = new System.Windows.Forms.Label();
            this.txtAddText = new System.Windows.Forms.TextBox();
            this.btnAddColour = new System.Windows.Forms.Button();
            this.lblAvailableColours = new System.Windows.Forms.Label();
            this.lbxAvailableColours = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxFavColours = new System.Windows.Forms.ListBox();
            this.lblFavourites = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dlgColourPicker = new System.Windows.Forms.ColorDialog();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(383, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Favourite Colour Picker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddColour
            // 
            this.lblAddColour.AutoSize = true;
            this.lblAddColour.Location = new System.Drawing.Point(39, 70);
            this.lblAddColour.Name = "lblAddColour";
            this.lblAddColour.Size = new System.Drawing.Size(68, 15);
            this.lblAddColour.TabIndex = 1;
            this.lblAddColour.Text = "Add &Colour";
            // 
            // txtAddText
            // 
            this.txtAddText.Location = new System.Drawing.Point(12, 471);
            this.txtAddText.Name = "txtAddText";
            this.txtAddText.Size = new System.Drawing.Size(59, 23);
            this.txtAddText.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtAddText, "Type in a colour name, then click add to add this colour to the List");
            // 
            // btnAddColour
            // 
            this.btnAddColour.Location = new System.Drawing.Point(113, 52);
            this.btnAddColour.Name = "btnAddColour";
            this.btnAddColour.Size = new System.Drawing.Size(79, 50);
            this.btnAddColour.TabIndex = 3;
            this.btnAddColour.Text = "&Add";
            this.toolTip1.SetToolTip(this.btnAddColour, "Add the entered colour to the available list");
            this.btnAddColour.UseVisualStyleBackColor = true;
            this.btnAddColour.Click += new System.EventHandler(this.btnAddColour_Click);
            // 
            // lblAvailableColours
            // 
            this.lblAvailableColours.AutoSize = true;
            this.lblAvailableColours.Location = new System.Drawing.Point(13, 121);
            this.lblAvailableColours.Name = "lblAvailableColours";
            this.lblAvailableColours.Size = new System.Drawing.Size(99, 15);
            this.lblAvailableColours.TabIndex = 4;
            this.lblAvailableColours.Text = "A&vailable Colours";
            // 
            // lbxAvailableColours
            // 
            this.lbxAvailableColours.FormattingEnabled = true;
            this.lbxAvailableColours.ItemHeight = 15;
            this.lbxAvailableColours.Location = new System.Drawing.Point(13, 139);
            this.lbxAvailableColours.Name = "lbxAvailableColours";
            this.lbxAvailableColours.Size = new System.Drawing.Size(132, 169);
            this.lbxAvailableColours.TabIndex = 5;
            this.toolTip1.SetToolTip(this.lbxAvailableColours, "List of Available colours");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(165, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">>";
            this.toolTip1.SetToolTip(this.btnAdd, "Move an available colour to favourite colours");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(165, 224);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 38);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<<";
            this.toolTip1.SetToolTip(this.btnRemove, "Remove a favourite colour to the available colour List");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxFavColours
            // 
            this.lbxFavColours.FormattingEnabled = true;
            this.lbxFavColours.ItemHeight = 15;
            this.lbxFavColours.Location = new System.Drawing.Point(229, 139);
            this.lbxFavColours.Name = "lbxFavColours";
            this.lbxFavColours.Size = new System.Drawing.Size(140, 169);
            this.lbxFavColours.TabIndex = 9;
            this.toolTip1.SetToolTip(this.lbxFavColours, "List of Favourite colours");
            // 
            // lblFavourites
            // 
            this.lblFavourites.AutoSize = true;
            this.lblFavourites.Location = new System.Drawing.Point(229, 121);
            this.lblFavourites.Name = "lblFavourites";
            this.lblFavourites.Size = new System.Drawing.Size(61, 15);
            this.lblFavourites.TabIndex = 8;
            this.lblFavourites.Text = "&Favourites";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(13, 328);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(356, 105);
            this.lblOutput.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(212, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 45);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Re&set";
            this.toolTip1.SetToolTip(this.btnReset, "Reset the Entire form to its default Values");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(294, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 45);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(97, 471);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(75, 22);
            this.btnAddTest.TabIndex = 13;
            this.btnAddTest.Text = "Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddColour;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(382, 506);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lbxFavColours);
            this.Controls.Add(this.lblFavourites);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxAvailableColours);
            this.Controls.Add(this.lblAvailableColours);
            this.Controls.Add(this.btnAddColour);
            this.Controls.Add(this.txtAddText);
            this.Controls.Add(this.lblAddColour);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(398, 545);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddColour;
        private System.Windows.Forms.TextBox txtAddText;
        private System.Windows.Forms.Button btnAddColour;
        private System.Windows.Forms.Label lblAvailableColours;
        private System.Windows.Forms.ListBox lbxAvailableColours;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxFavColours;
        private System.Windows.Forms.Label lblFavourites;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog dlgColourPicker;
        private System.Windows.Forms.Button btnAddTest;
    }
}

