
namespace ICE04_Classes
{
    partial class frmFavouriteGame
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxSelection = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbxReplay = new System.Windows.Forms.CheckBox();
            this.cboFavourite = new System.Windows.Forms.ComboBox();
            this.lblFavourite = new System.Windows.Forms.Label();
            this.cboConsole = new System.Windows.Forms.ComboBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.nudDesignation = new System.Windows.Forms.NumericUpDown();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConsole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFavouritePart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, -3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(754, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Favourite Games";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxSelection
            // 
            this.gbxSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxSelection.Controls.Add(this.btnSave);
            this.gbxSelection.Controls.Add(this.btnReset);
            this.gbxSelection.Controls.Add(this.cbxReplay);
            this.gbxSelection.Controls.Add(this.cboFavourite);
            this.gbxSelection.Controls.Add(this.lblFavourite);
            this.gbxSelection.Controls.Add(this.cboConsole);
            this.gbxSelection.Controls.Add(this.lblConsole);
            this.gbxSelection.Controls.Add(this.txtName);
            this.gbxSelection.Controls.Add(this.lblName);
            this.gbxSelection.Controls.Add(this.nudDesignation);
            this.gbxSelection.Controls.Add(this.lblDesignation);
            this.gbxSelection.Location = new System.Drawing.Point(12, 244);
            this.gbxSelection.Name = "gbxSelection";
            this.gbxSelection.Size = new System.Drawing.Size(352, 194);
            this.gbxSelection.TabIndex = 1;
            this.gbxSelection.TabStop = false;
            this.gbxSelection.Text = "Add / Edit";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(258, 101);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbxReplay
            // 
            this.cbxReplay.AutoSize = true;
            this.cbxReplay.Location = new System.Drawing.Point(66, 166);
            this.cbxReplay.Name = "cbxReplay";
            this.cbxReplay.Size = new System.Drawing.Size(83, 19);
            this.cbxReplay.TabIndex = 8;
            this.cbxReplay.Text = "Re&playable";
            this.cbxReplay.UseVisualStyleBackColor = true;
            // 
            // cboFavourite
            // 
            this.cboFavourite.FormattingEnabled = true;
            this.cboFavourite.Location = new System.Drawing.Point(94, 133);
            this.cboFavourite.Name = "cboFavourite";
            this.cboFavourite.Size = new System.Drawing.Size(150, 23);
            this.cboFavourite.TabIndex = 7;
            // 
            // lblFavourite
            // 
            this.lblFavourite.AutoSize = true;
            this.lblFavourite.Location = new System.Drawing.Point(5, 136);
            this.lblFavourite.Name = "lblFavourite";
            this.lblFavourite.Size = new System.Drawing.Size(83, 15);
            this.lblFavourite.TabIndex = 6;
            this.lblFavourite.Text = "&Favourite Part:";
            // 
            // cboConsole
            // 
            this.cboConsole.FormattingEnabled = true;
            this.cboConsole.Location = new System.Drawing.Point(94, 99);
            this.cboConsole.Name = "cboConsole";
            this.cboConsole.Size = new System.Drawing.Size(150, 23);
            this.cboConsole.TabIndex = 5;
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(6, 103);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(53, 15);
            this.lblConsole.TabIndex = 4;
            this.lblConsole.Text = "&Console:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "&Game Name:";
            // 
            // nudDesignation
            // 
            this.nudDesignation.Location = new System.Drawing.Point(94, 30);
            this.nudDesignation.Name = "nudDesignation";
            this.nudDesignation.Size = new System.Drawing.Size(84, 23);
            this.nudDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(6, 32);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(73, 15);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "&Designation:";
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesignation,
            this.colGameName,
            this.colConsole,
            this.colFavouritePart,
            this.colReplayable});
            this.dgvGames.Location = new System.Drawing.Point(12, 40);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowTemplate.Height = 25;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.ShowEditingIcon = false;
            this.dgvGames.Size = new System.Drawing.Size(729, 198);
            this.dgvGames.TabIndex = 2;
            this.dgvGames.VirtualMode = true;
            // 
            // colDesignation
            // 
            this.colDesignation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesignation.DataPropertyName = "Designation";
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            this.colDesignation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colGameName
            // 
            this.colGameName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGameName.DataPropertyName = "GameName";
            this.colGameName.HeaderText = "Game Name";
            this.colGameName.MinimumWidth = 250;
            this.colGameName.Name = "colGameName";
            this.colGameName.ReadOnly = true;
            this.colGameName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGameName.Width = 250;
            // 
            // colConsole
            // 
            this.colConsole.DataPropertyName = "Console";
            this.colConsole.HeaderText = "Console";
            this.colConsole.Name = "colConsole";
            this.colConsole.ReadOnly = true;
            this.colConsole.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colConsole.Width = 119;
            // 
            // colFavouritePart
            // 
            this.colFavouritePart.DataPropertyName = "Favourite";
            this.colFavouritePart.HeaderText = "Favourite Part";
            this.colFavouritePart.Name = "colFavouritePart";
            this.colFavouritePart.ReadOnly = true;
            this.colFavouritePart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFavouritePart.Width = 119;
            // 
            // colReplayable
            // 
            this.colReplayable.DataPropertyName = "Replayable";
            this.colReplayable.HeaderText = "Replayable";
            this.colReplayable.Name = "colReplayable";
            this.colReplayable.ReadOnly = true;
            this.colReplayable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReplayable.Width = 119;
            // 
            // frmFavouriteGame
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.gbxSelection);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFavouriteGame";
            this.Text = "Favourite Game";
            this.Load += new System.EventHandler(this.frmFavouriteGame_Load);
            this.gbxSelection.ResumeLayout(false);
            this.gbxSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxSelection;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.NumericUpDown nudDesignation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.ComboBox cboConsole;
        private System.Windows.Forms.Label lblFavourite;
        private System.Windows.Forms.ComboBox cboFavourite;
        private System.Windows.Forms.CheckBox cbxReplay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFavouritePart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplayable;
    }
}

