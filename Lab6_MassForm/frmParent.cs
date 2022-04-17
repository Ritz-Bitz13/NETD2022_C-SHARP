#region App Created by:
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


        #region ~~ File Buttons ~~

        #region New Form
        private void ShowNewForm(object sender, EventArgs e)
        {
            // This will open a new form
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        #endregion

        #region Open File
        private void OpenFile(object sender, EventArgs e)
        {
            // Uses the method open Files to open a file on the text Editor
            OpenFilesMethod();
        }
        #endregion

        #region File Save
        private void msFileSave_Click(object sender, EventArgs e)
        {
            // This will save Items in the text editor
            SavePressed();
        }
        #endregion

        #region Tool Strip Save
        private void tsSave_Click(object sender, EventArgs e)
        {
            // This will save Items in the text editor
            SavePressed();
        }
        #endregion

        #region Save As
        private void msSaveAs(object sender, EventArgs e)
        {
            // This will save Items in the text editor
            SavePressed();
        }
        #endregion

        #region Exit Button
        private void msFileExit_Click(object sender, EventArgs e)
        {
            // This will exit the program if the user says yes
            if (MessageBox.Show("Would you like to close the application?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes);
            {
                Application.Exit();
            }
        }
        #endregion

        #endregion

        #region ~~ Edit Buttons ~~

        #region Cut
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(frmMain.selectedText);
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

        #region ~~ Extra Button ~~ (Temperature Calculation Form)
        private void smToolsTemperature_Click(object sender, EventArgs e)
        {
            // This will open the temperature calcualtion form

            frmTemperature frm = frmTemperature.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region ~~ Windows Button ~~

        #region Cascade
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); // This will cascade the forms that are open
        }
        #endregion

        #region Tile Vertical
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); // This will Stack the forms vertical that are open
        }
        #endregion

        #region Tile Horizontal
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); // This will Stack the forms Horizontal that are open
        }
        #endregion

        #region Weekly Cases Form
        private void msWindowsWeeklyCases(object sender, EventArgs e)
        {
            // This will open the Weekly Cases form

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

        #region ~~ Help Buttons ~~
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

        #region Text Editor Form
        private void msTextFiles_Click(object sender, EventArgs e)
        {
            // This will open the TextEditor Form
            frmMain frm = frmMain.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frmMain.Opened = true; // sets the variable to true because the form is opened
            frm.Focus();
        }
        #endregion

        #region GPA Calculator Form
        private void msGPACalculate_Click(object sender, EventArgs e)
        {
            // This will open the GPA grade calculator

            frmGPAGrades frm = frmGPAGrades.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Awesomeness Form
        private void ssAwesomeness(object sender, EventArgs e)
        {
            // This will open the first ICE, Awesomeness

            frmAwesomeness frm = frmAwesomeness.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Custom Class Form
        private void msClassEditor_Click(object sender, EventArgs e)
        {
            //This will oppen the Class Editor

            frmFavouriteGame frm = frmFavouriteGame.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Customer Entry Form
        private void msCustomerEntry_Click(object sender, EventArgs e)
        {
            // This will open the Customer Entry Form

            formCustomerEntry frm = formCustomerEntry.Instance; //refrencing the listtropopers form 'Get'
            frm.MdiParent = this; // Make this the current form
            frm.Show(); // This will show the form but allow you to go off the form
            frm.Focus();
        }
        #endregion

        #region Custom Methods

        #region Help Button Pressed
        /// <summary>
        /// When you hit the help button it will open the about form
        /// </summary>
        private void HelpForm()
        {
            frmAbout newForm = new frmAbout(); // Brings up the about form
            newForm.ShowDialog();
            newForm.Dispose();
        }
        #endregion

        #region Save Button Pressed Method
        /// <summary>
        /// This will take the information on the rich text box from Lab 5 and save it to a document
        /// </summary>
        private void SavePressed()
        {
            if (frmMain.Instance == ActiveMdiChild)
            {
                MessageBox.Show("Text editor is the main form. Saving Commencing", "Saving");
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                    FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(frmMain.passingText);
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Im Sorry, You can not save unless the focused form is the Text editor.", "Error");
            }
        }
        #endregion

        #region Open files
        /// <summary>
        /// This will open the file dialog and you can open a text file to open in the text editor
        /// </summary>
        private void OpenFilesMethod()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // If the textbox form is open AND is the active child. open the file
                if (frmMain.Instance == ActiveMdiChild)
                {
                    frmMain.Instance.Close();
                    frmMain.passingText = File.ReadAllText(openFileDialog.FileName);
                    frmMain frm = frmMain.Instance;
                    frm.MdiParent = this;
                    frm.Show();
                    frm.Focus();
                }

                // If the Text Editor form is open BUT is not the focused form, it will close the form and reopen it to focus, along with the files.
                else if (frmMain.Opened == true)
                {
                    frmMain.Instance.Close();
                    frmMain.passingText = File.ReadAllText(openFileDialog.FileName);
                    frmMain frm = frmMain.Instance;
                    frm.MdiParent = this;
                    frm.Show();
                    frm.Focus();
                }
                // If the textform is NOT open. Then open the file and make it the focus.
                else
                {
                    frmMain.passingText = File.ReadAllText(openFileDialog.FileName);
                    frmMain frm = frmMain.Instance;
                    frm.MdiParent = this;
                    frm.Show();
                    frm.Focus(); ;
                }
            }
        }

        #endregion

        #endregion

    }
}
