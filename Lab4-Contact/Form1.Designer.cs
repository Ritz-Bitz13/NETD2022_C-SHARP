
namespace Lab4_Contact
{
    partial class frmContactTracing
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.chkContacted = new System.Windows.Forms.CheckBox();
            this.dgvTracing = new System.Windows.Forms.DataGridView();
            this.colContacted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracing)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(180, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "&First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(253, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(253, 46);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(180, 49);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "&Last Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(253, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(157, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-&Mail Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(253, 104);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(155, 107);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "&Phone Number:";
            // 
            // chkContacted
            // 
            this.chkContacted.AutoSize = true;
            this.chkContacted.Location = new System.Drawing.Point(186, 133);
            this.chkContacted.Name = "chkContacted";
            this.chkContacted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkContacted.Size = new System.Drawing.Size(81, 19);
            this.chkContacted.TabIndex = 8;
            this.chkContacted.Text = "&Contacted";
            this.chkContacted.UseVisualStyleBackColor = true;
            // 
            // dgvTracing
            // 
            this.dgvTracing.AllowUserToAddRows = false;
            this.dgvTracing.AllowUserToDeleteRows = false;
            this.dgvTracing.AllowUserToResizeColumns = false;
            this.dgvTracing.AllowUserToResizeRows = false;
            this.dgvTracing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTracing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTracing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTracing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContacted,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone});
            this.dgvTracing.Location = new System.Drawing.Point(12, 158);
            this.dgvTracing.Name = "dgvTracing";
            this.dgvTracing.ReadOnly = true;
            this.dgvTracing.RowHeadersVisible = false;
            this.dgvTracing.RowTemplate.Height = 25;
            this.dgvTracing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracing.ShowEditingIcon = false;
            this.dgvTracing.Size = new System.Drawing.Size(558, 195);
            this.dgvTracing.TabIndex = 9;
            // 
            // colContacted
            // 
            this.colContacted.DataPropertyName = "Contacted";
            this.colContacted.HeaderText = "Contacted";
            this.colContacted.Name = "colContacted";
            this.colContacted.ReadOnly = true;
            this.colContacted.Width = 87;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 89;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 88;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-Mail Address";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 111;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone Number";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 113;
            // 
            // lblErrors
            // 
            this.lblErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrors.Location = new System.Drawing.Point(9, 359);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(561, 105);
            this.lblErrors.TabIndex = 10;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(318, 470);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Re&set";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmContactTracing
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.dgvTracing);
            this.Controls.Add(this.chkContacted);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmContactTracing";
            this.Text = "Contact Tracing";
            this.Load += new System.EventHandler(this.frmContactTracing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.CheckBox chkContacted;
        private System.Windows.Forms.DataGridView dgvTracing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

