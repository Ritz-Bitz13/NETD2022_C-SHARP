
namespace Lab6_MassForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssSaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtInformation = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit,
            this.msHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileNew,
            this.msFileOpen,
            this.msFileSave,
            this.msFileSaveAs,
            this.msFileClose,
            this.msFileExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "&File";
            this.msFile.Click += new System.EventHandler(this.msFile_Click);
            // 
            // msFileNew
            // 
            this.msFileNew.Name = "msFileNew";
            this.msFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.msFileNew.Size = new System.Drawing.Size(157, 22);
            this.msFileNew.Text = "&New";
            this.msFileNew.Click += new System.EventHandler(this.msFileNew_Click);
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.msFileOpen.Size = new System.Drawing.Size(157, 22);
            this.msFileOpen.Text = "&Open";
            this.msFileOpen.Click += new System.EventHandler(this.msFileOpen_Click);
            // 
            // msFileSave
            // 
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msFileSave.Size = new System.Drawing.Size(157, 22);
            this.msFileSave.Text = "Save";
            this.msFileSave.Click += new System.EventHandler(this.msFileSave_Click);
            // 
            // msFileSaveAs
            // 
            this.msFileSaveAs.Name = "msFileSaveAs";
            this.msFileSaveAs.Size = new System.Drawing.Size(157, 22);
            this.msFileSaveAs.Text = "Save &As..";
            this.msFileSaveAs.Click += new System.EventHandler(this.msFileSaveAs_Click);
            // 
            // msFileClose
            // 
            this.msFileClose.Name = "msFileClose";
            this.msFileClose.Size = new System.Drawing.Size(157, 22);
            this.msFileClose.Text = "Close";
            this.msFileClose.Click += new System.EventHandler(this.msFileClose_Click);
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.msFileExit.Size = new System.Drawing.Size(157, 22);
            this.msFileExit.Text = "E&xit";
            this.msFileExit.Click += new System.EventHandler(this.msFileExit_Click);
            // 
            // msEdit
            // 
            this.msEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEditCopy,
            this.msEditCut,
            this.msEditPaste});
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(39, 20);
            this.msEdit.Text = "&Edit";
            // 
            // msEditCopy
            // 
            this.msEditCopy.Name = "msEditCopy";
            this.msEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msEditCopy.Size = new System.Drawing.Size(180, 22);
            this.msEditCopy.Text = "&Copy";
            this.msEditCopy.Click += new System.EventHandler(this.msEditCopy_Click);
            // 
            // msEditCut
            // 
            this.msEditCut.Name = "msEditCut";
            this.msEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msEditCut.Size = new System.Drawing.Size(180, 22);
            this.msEditCut.Text = "Cu&t";
            this.msEditCut.Click += new System.EventHandler(this.msEditCut_Click);
            // 
            // msEditPaste
            // 
            this.msEditPaste.Name = "msEditPaste";
            this.msEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msEditPaste.Size = new System.Drawing.Size(180, 22);
            this.msEditPaste.Text = "&Paste";
            this.msEditPaste.Click += new System.EventHandler(this.msEditPaste_Click);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelpAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(44, 20);
            this.msHelp.Text = "&Help";
            // 
            // msHelpAbout
            // 
            this.msHelpAbout.Name = "msHelpAbout";
            this.msHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.msHelpAbout.Size = new System.Drawing.Size(126, 22);
            this.msHelpAbout.Text = "About";
            this.msHelpAbout.Click += new System.EventHandler(this.msHelpAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssSaveStatus,
            this.ssFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssSaveStatus
            // 
            this.ssSaveStatus.BackColor = System.Drawing.Color.Lime;
            this.ssSaveStatus.Name = "ssSaveStatus";
            this.ssSaveStatus.Size = new System.Drawing.Size(38, 17);
            this.ssSaveStatus.Text = "Saved";
            // 
            // ssFileName
            // 
            this.ssFileName.Name = "ssFileName";
            this.ssFileName.Size = new System.Drawing.Size(17, 17);
            this.ssFileName.Text = "--";
            // 
            // txtInformation
            // 
            this.txtInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformation.Location = new System.Drawing.Point(0, 27);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(800, 398);
            this.txtInformation.TabIndex = 3;
            this.txtInformation.Text = "";
            this.txtInformation.TextChanged += new System.EventHandler(this.textchanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor, Select a file to Open";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.Load += new System.EventHandler(this.DisableMenu);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msFileNew;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.ToolStripMenuItem msFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem msFileClose;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msEditCopy;
        private System.Windows.Forms.ToolStripMenuItem msEditCut;
        private System.Windows.Forms.ToolStripMenuItem msEditPaste;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssSaveStatus;
        private System.Windows.Forms.ToolStripStatusLabel ssFileName;
        internal System.Windows.Forms.RichTextBox txtInformation;
    }
}

