
namespace Lab6_MassForm
{
    partial class frmParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.msEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.msTools = new System.Windows.Forms.ToolStripMenuItem();
            this.smToolsTemperature = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.msWIndowsTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.msWIndowsTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.msWeeklyCase = new System.Windows.Forms.ToolStripMenuItem();
            this.contactTracingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msTextFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.msGPACalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.smAwesomeness = new System.Windows.Forms.ToolStripMenuItem();
            this.msClassEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.msCustomerEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsNewFile = new System.Windows.Forms.ToolStripButton();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit,
            this.msTools,
            this.msWindows,
            this.msHelp,
            this.msTextFiles,
            this.msGPACalculate,
            this.smAwesomeness,
            this.msClassEditor,
            this.msCustomerEntry});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.msWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileNew,
            this.msFileOpen,
            this.toolStripSeparator3,
            this.msFileSave,
            this.msFileSaveAs,
            this.toolStripSeparator4,
            this.msFileExit});
            this.msFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "&File";
            this.msFile.Click += new System.EventHandler(this.msFile_Click);
            // 
            // msFileNew
            // 
            this.msFileNew.Image = ((System.Drawing.Image)(resources.GetObject("msFileNew.Image")));
            this.msFileNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.msFileNew.Name = "msFileNew";
            this.msFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.msFileNew.Size = new System.Drawing.Size(168, 22);
            this.msFileNew.Text = "&New";
            this.msFileNew.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // msFileOpen
            // 
            this.msFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("msFileOpen.Image")));
            this.msFileOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.msFileOpen.Size = new System.Drawing.Size(168, 22);
            this.msFileOpen.Text = "&Open";
            this.msFileOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // msFileSave
            // 
            this.msFileSave.Image = ((System.Drawing.Image)(resources.GetObject("msFileSave.Image")));
            this.msFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msFileSave.Size = new System.Drawing.Size(168, 22);
            this.msFileSave.Text = "&Save";
            this.msFileSave.Click += new System.EventHandler(this.msFileSave_Click);
            // 
            // msFileSaveAs
            // 
            this.msFileSaveAs.Name = "msFileSaveAs";
            this.msFileSaveAs.Size = new System.Drawing.Size(168, 22);
            this.msFileSaveAs.Text = "Save &As";
            this.msFileSaveAs.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.msFileExit.Size = new System.Drawing.Size(168, 22);
            this.msFileExit.Text = "E&xit";
            this.msFileExit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // msEdit
            // 
            this.msEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEditCut,
            this.msEditCopy,
            this.msEditPaste,
            this.toolStripSeparator7,
            this.msEditSelectAll});
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(39, 20);
            this.msEdit.Text = "&Edit";
            // 
            // msEditCut
            // 
            this.msEditCut.Image = ((System.Drawing.Image)(resources.GetObject("msEditCut.Image")));
            this.msEditCut.ImageTransparentColor = System.Drawing.Color.Black;
            this.msEditCut.Name = "msEditCut";
            this.msEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msEditCut.Size = new System.Drawing.Size(164, 22);
            this.msEditCut.Text = "Cu&t";
            this.msEditCut.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // msEditCopy
            // 
            this.msEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("msEditCopy.Image")));
            this.msEditCopy.ImageTransparentColor = System.Drawing.Color.Black;
            this.msEditCopy.Name = "msEditCopy";
            this.msEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msEditCopy.Size = new System.Drawing.Size(164, 22);
            this.msEditCopy.Text = "&Copy";
            this.msEditCopy.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // msEditPaste
            // 
            this.msEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("msEditPaste.Image")));
            this.msEditPaste.ImageTransparentColor = System.Drawing.Color.Black;
            this.msEditPaste.Name = "msEditPaste";
            this.msEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msEditPaste.Size = new System.Drawing.Size(164, 22);
            this.msEditPaste.Text = "&Paste";
            this.msEditPaste.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // msEditSelectAll
            // 
            this.msEditSelectAll.Name = "msEditSelectAll";
            this.msEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.msEditSelectAll.Size = new System.Drawing.Size(164, 22);
            this.msEditSelectAll.Text = "Select &All";
            // 
            // msTools
            // 
            this.msTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smToolsTemperature});
            this.msTools.Name = "msTools";
            this.msTools.Size = new System.Drawing.Size(45, 20);
            this.msTools.Text = "Ex&tra";
            // 
            // smToolsTemperature
            // 
            this.smToolsTemperature.Name = "smToolsTemperature";
            this.smToolsTemperature.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.smToolsTemperature.Size = new System.Drawing.Size(266, 22);
            this.smToolsTemperature.Text = "Temperature Conversion";
            this.smToolsTemperature.Click += new System.EventHandler(this.smToolsTemperature_Click);
            // 
            // msWindows
            // 
            this.msWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msWindowsCascade,
            this.msWIndowsTileVertical,
            this.msWIndowsTileHorizontal,
            this.msWeeklyCase,
            this.contactTracingToolStripMenuItem});
            this.msWindows.Name = "msWindows";
            this.msWindows.Size = new System.Drawing.Size(68, 20);
            this.msWindows.Text = "&Windows";
            // 
            // msWindowsCascade
            // 
            this.msWindowsCascade.Name = "msWindowsCascade";
            this.msWindowsCascade.Size = new System.Drawing.Size(157, 22);
            this.msWindowsCascade.Text = "&Cascade";
            this.msWindowsCascade.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // msWIndowsTileVertical
            // 
            this.msWIndowsTileVertical.Name = "msWIndowsTileVertical";
            this.msWIndowsTileVertical.Size = new System.Drawing.Size(157, 22);
            this.msWIndowsTileVertical.Text = "Tile &Vertical";
            this.msWIndowsTileVertical.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // msWIndowsTileHorizontal
            // 
            this.msWIndowsTileHorizontal.Name = "msWIndowsTileHorizontal";
            this.msWIndowsTileHorizontal.Size = new System.Drawing.Size(157, 22);
            this.msWIndowsTileHorizontal.Text = "Tile &Horizontal";
            this.msWIndowsTileHorizontal.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // msWeeklyCase
            // 
            this.msWeeklyCase.Name = "msWeeklyCase";
            this.msWeeklyCase.Size = new System.Drawing.Size(157, 22);
            this.msWeeklyCase.Text = "Weekly Cases";
            this.msWeeklyCase.Click += new System.EventHandler(this.weeklyCasesToolStripMenuItem_Click);
            // 
            // contactTracingToolStripMenuItem
            // 
            this.contactTracingToolStripMenuItem.Name = "contactTracingToolStripMenuItem";
            this.contactTracingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.contactTracingToolStripMenuItem.Text = "Contact Tracing";
            this.contactTracingToolStripMenuItem.Click += new System.EventHandler(this.contactTracingToolStripMenuItem_Click);
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
            this.msHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.msHelpAbout.Text = "&About";
            this.msHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // msTextFiles
            // 
            this.msTextFiles.Name = "msTextFiles";
            this.msTextFiles.Size = new System.Drawing.Size(66, 20);
            this.msTextFiles.Text = "Te&xt Files";
            this.msTextFiles.Click += new System.EventHandler(this.msTextFiles_Click);
            // 
            // msGPACalculate
            // 
            this.msGPACalculate.Name = "msGPACalculate";
            this.msGPACalculate.Size = new System.Drawing.Size(98, 20);
            this.msGPACalculate.Text = "&GPA Calculator";
            this.msGPACalculate.Click += new System.EventHandler(this.msGPACalculate_Click);
            // 
            // smAwesomeness
            // 
            this.smAwesomeness.Name = "smAwesomeness";
            this.smAwesomeness.Size = new System.Drawing.Size(94, 20);
            this.smAwesomeness.Text = "&Awesomeness";
            this.smAwesomeness.Click += new System.EventHandler(this.awesomenessToolStripMenuItem_Click);
            // 
            // msClassEditor
            // 
            this.msClassEditor.Name = "msClassEditor";
            this.msClassEditor.Size = new System.Drawing.Size(125, 20);
            this.msClassEditor.Text = "&Custom Class Editor";
            this.msClassEditor.Click += new System.EventHandler(this.msClassEditor_Click);
            // 
            // msCustomerEntry
            // 
            this.msCustomerEntry.Name = "msCustomerEntry";
            this.msCustomerEntry.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.msCustomerEntry.Size = new System.Drawing.Size(101, 20);
            this.msCustomerEntry.Text = "C&ustomer Entry";
            this.msCustomerEntry.Click += new System.EventHandler(this.msCustomerEntry_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewFile,
            this.tsOpen,
            this.tsSave,
            this.toolStripSeparator1,
            this.tsHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1234, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsNewFile
            // 
            this.tsNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tsNewFile.Image")));
            this.tsNewFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsNewFile.Name = "tsNewFile";
            this.tsNewFile.Size = new System.Drawing.Size(23, 22);
            this.tsNewFile.Text = "New";
            this.tsNewFile.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // tsOpen
            // 
            this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsOpen.Image")));
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(23, 22);
            this.tsOpen.Text = "Open";
            this.tsOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsHelp
            // 
            this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsHelp.Image")));
            this.tsHelp.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(23, 22);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 750);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // ssStatus
            // 
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(39, 17);
            this.ssStatus.Text = "Status";
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 772);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NETD 2201 Labs and ICE\'s in a Single MultiForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel ssStatus;
        private System.Windows.Forms.ToolStripMenuItem msWIndowsTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msFileNew;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.ToolStripMenuItem msFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripMenuItem msEditCut;
        private System.Windows.Forms.ToolStripMenuItem msEditCopy;
        private System.Windows.Forms.ToolStripMenuItem msEditPaste;
        private System.Windows.Forms.ToolStripMenuItem msEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem msTools;
        private System.Windows.Forms.ToolStripMenuItem msWindows;
        private System.Windows.Forms.ToolStripMenuItem msWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem msWIndowsTileVertical;
        private System.Windows.Forms.ToolStripButton tsNewFile;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsHelp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem msTextFiles;
        private System.Windows.Forms.ToolStripMenuItem smToolsTemperature;
        private System.Windows.Forms.ToolStripMenuItem msWeeklyCase;
        private System.Windows.Forms.ToolStripMenuItem contactTracingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem msGPACalculate;
        private System.Windows.Forms.ToolStripMenuItem smAwesomeness;
        private System.Windows.Forms.ToolStripMenuItem msClassEditor;
        private System.Windows.Forms.ToolStripMenuItem msCustomerEntry;
    }
}



