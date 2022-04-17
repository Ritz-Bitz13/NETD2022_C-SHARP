﻿#region App Created by:
/*
 * Author:          Martin Barber & Michael Parisi
 * Date:            April 8th, 2022 - April 17th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 6: Multi Form, Most past ICE's / Labs together in a single Project
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
#endregion

#region Namespace and Initialize Component
namespace Lab6_MassForm
{
    public partial class frmParent : Form
    {
        private int childFormNumber = 0;

        public frmParent()
        {
            InitializeComponent();
        }
        #endregion


        #region All Menu / File Buttons

        #region New Form
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        #endregion

        #region Open File
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                frmMain frm = new frmMain(); //refrencing the listtropopers form 'Get'
                frm.MdiParent = this; // Make this the current form
                frm.Show(); // This will show the form but allow syou to go off the form
                frm.Focus();

                string FileName = openFileDialog.FileName;
            }
        }
        #endregion

        #region File Save
        private void msFileSave_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tool Strip Save
        private void tsSave_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance == ActiveMdiChild)
            {
                MessageBox.Show("Active form is Lab5");
            }
            else
            {
                MessageBox.Show("Im Sorry, You can not save unless the focused form is the Text editor.", "Error");
            }
        }
        #endregion

        #region Save As
        private void msSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        #endregion

        #region Exit Button
        private void msFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to close the application?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes);
            {
                Application.Exit();
            }
        }
        #endregion

        #endregion

        #region All Edit Buttons

        #region Cut
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Copy
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Paste
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Select All
        private void msEditSelectAll_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region Extra Button (Temperature Calculation Form)
        private void smToolsTemperature_Click(object sender, EventArgs e)
        {
            frmTemperature frm = frmTemperature.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Windows Button

        #region Cascade
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        #endregion

        #region Tile Vertical
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

        #region Tile Horizontal
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion

        #region Weekly Cases Form
        private void msWindowsWeeklyCases(object sender, EventArgs e)
        {
            frmCases frm = frmCases.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Contact Tracing Form
        private void msContactTracing(object sender, EventArgs e)
        {
            frmContactTracing frm = frmContactTracing.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #endregion

        #region Help Buttons
        // This is on the Tool Strip
        private void tsHelp_Click(object sender, EventArgs e)
        {
            HelpForm();
        }

        //This is on the menu strip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm();
        }
        #endregion

        #region Text Editor
        private void msTextFiles_Click(object sender, EventArgs e)
        {
            frmMain frm = frmMain.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region GPA Calculator
        private void msGPACalculate_Click(object sender, EventArgs e)
        {
            frmGPAGrades frm = frmGPAGrades.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Awesomeness Form
        private void ssAwesomeness(object sender, EventArgs e)
        {
            frmAwesomeness frm = frmAwesomeness.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Custom Class Form
        private void msClassEditor_Click(object sender, EventArgs e)
        {
            frmFavouriteGame frm = frmFavouriteGame.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Customer Entry
        private void msCustomerEntry_Click(object sender, EventArgs e)
        {
            formCustomerEntry frm = formCustomerEntry.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Custom Methods
        private void HelpForm()
        {
            frmAbout newForm = new frmAbout(); // Brings up the about form
            newForm.ShowDialog();
            newForm.Dispose();
        }

        private void SavePressed()
        {
            if (frmMain.Instance == ActiveMdiChild)
            {
                MessageBox.Show("Active form is Lab5");
            }
            else
            {
                MessageBox.Show("Im Sorry, You can not save unless the focused form is the Text editor.", "Error");
            }
        }
        #endregion

    }
}
