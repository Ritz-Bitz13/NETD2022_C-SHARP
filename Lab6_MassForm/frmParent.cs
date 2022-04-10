﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_MassForm
{
    public partial class frmParent : Form
    {
        private int childFormNumber = 0;

        public frmParent()
        {
            InitializeComponent();
        }

        #region Menu / Tool Strip Buttons
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {

        }

        private void tsPrint_Click(object sender, EventArgs e)
        {

        }

        private void tsSearch_Click(object sender, EventArgs e)
        {

        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            HelpForm();
        }
        #endregion

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = msViewToolbar.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = msViewStatusBar.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm();
        }


        #region Custom Methods
        private void HelpForm()
        {
            frmAbout newForm = new frmAbout(); // Brings up the about form
            newForm.ShowDialog();
            newForm.Dispose();
        }
        #endregion

        private void msWeeklyCases_Click(object sender, EventArgs e)
        {
            frmCases frm = new frmCases(); //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }

        private void msFileSave_Click(object sender, EventArgs e)
        {

        }

        private void msContactTracing_Click(object sender, EventArgs e)
        {
            frmContactTracing frm = new frmContactTracing(); //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }

        private void msTextFiles_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(); //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }

        private void smToolsTemperature_Click(object sender, EventArgs e)
        {
            frmTemperature frm = new frmTemperature(); //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
    }
}
