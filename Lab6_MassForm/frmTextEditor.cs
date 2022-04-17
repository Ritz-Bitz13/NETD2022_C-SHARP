#region App Created by:
/*
 * Author:          Martin Barber
 * Date:            March 30th, 2022 - April 4th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 5: Text File Creater
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
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Lab6_MassForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Global Variables
        public static List<Information> Document = new List<Information>();

        private static frmMain textInstance;

        public static frmMain Instance
        {
            get
            {
                if (textInstance == null)
                    textInstance = new frmMain();
                return textInstance;
            }
        }
        bool activeform;


        #endregion

        #region FILE BUTTONS
        #region  New File
        /// <summary>
        /// New file will open up a new document to start fresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileNew_Click(object sender, EventArgs e)
        {
            ConfirmClose(); // Check if there are any changes before creating a new file.
        }
        #endregion

        #region Open Button
        /// <summary>
        /// Open Button Will open up a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileOpen_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }
        #endregion

        #region Save Button
        /// <summary>
        /// Save button, SAve the file automatically if it has a file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void msFileSave_Click(object sender, EventArgs e)
        {
            Document.Clear(); // clears the list
            Information t = new Information();
            t.Info = this.txtInformation.Text.Trim();
            Document.Add(t); // adds the file to the list
            SaveToFile(false); // Set the savetofile is red
        }
        #endregion

        #region Save As
        /// <summary>
        /// Save as button, Will automatically bring up the save file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void msFileSaveAs_Click(object sender, EventArgs e)
        {
            Document.Clear();
            Information t = new Information();
            t.Info = this.txtInformation.Text.Trim();
            Document.Add(t);
            SaveToFile(true);
        }
        #endregion

        #region Close
        /// <summary>
        /// this will close the current file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileClose_Click(object sender, EventArgs e)
        {
            ConfirmClose(); // Check if there are any changes before closing the file
        }
        #endregion

        #region Exit
        /// <summary>
        /// This will Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileExit_Click(object sender, EventArgs e)
        {
            ConfirmClose(); // Check if there are any changes before closing the application
            this.Close();
        }
        #endregion

        #endregion

        #region EDIT BUTTONS

        #region Copy
        /// <summary>
        /// This will copy the selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditCopy_Click(object sender, EventArgs e)
        {
            if (txtInformation.SelectionLength > 0) // If the user has selected text
            {
                Clipboard.SetText(txtInformation.SelectedText); //This will copy the selected information
            }
        }
        #endregion

        #region Cut
        /// <summary>
        /// THis will cut the selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditCut_Click(object sender, EventArgs e)
        {
            if (txtInformation.SelectionLength > 0) // If the user has selected text
            {
                Clipboard.SetText(txtInformation.SelectedText); // This will cut the selected information
                txtInformation.SelectedText = string.Empty;
            }
        }
        #endregion

        #region Paste
        /// <summary>
        /// This will Paste the selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditPaste_Click(object sender, EventArgs e)
        {
            string data = Clipboard.GetText();
            txtInformation.Text = txtInformation.Text.Insert(txtInformation.SelectionStart, data); // Paste the information
        }
        #endregion

        #endregion

        #region Help
        /// <summary>
        ///  This will open the frmAbout and display the help information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout(); // Brings up the about form
            newForm.ShowDialog();
            newForm.Dispose();
        }
        #endregion

        #region Custom Methods

        #region Save Status
        /// <summary>
        /// Sets the save status to edited or saved
        /// </summary>
        /// <param name="isSaved"></param>
        public void SetSaveStatus(Boolean isSaved)
        {
            if (isSaved)
            {
                this.ssSaveStatus.BackColor = Color.Lime; // Green background
                this.ssSaveStatus.Text = "Saved"; // Show the file has been saved
            }
            else
            {
                this.ssSaveStatus.BackColor = Color.Red; // Red background
                this.ssSaveStatus.Text = "Edited"; // Show the file has changes without being saved
            }
        }
        #endregion

        #region Save to File
        /// <summary>
        /// If the file has a file name it will automatically save, if not, it will ask you to save it to a file.
        /// </summary>
        /// <param name="saveAs"></param>
        public void SaveToFile(Boolean saveAs)
        {
            //TODO: SaveAs with existing filename
            if (!saveAs && ssFileName.Text.Length > 4)
            {
                Information.FileWrite(Document, ssFileName.Text); // If we have a file name we will use the name of that file
                MessageBox.Show("Save Complete", "Save Confirmation", MessageBoxButtons.OK);
            }
            else
            {
                // If we do not have a file name, then it will create one
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Information.FileWrite(Document, saveFileDialog1.FileName);
                    MessageBox.Show("Save Complete", "Save Confirmation", MessageBoxButtons.OK);
                    this.ssFileName.Text = saveFileDialog1.FileName;
                }
            }
            SetSaveStatus(true);
        }
        #endregion

        #region Open Files
        /// <summary>
        /// This is the method to open up files in the text box
        /// </summary>
        private void OpenFiles()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt) | *.txt|All Files(*.*)|**.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ssFileName.Text = openFile.FileName;
                txtInformation.Text = File.ReadAllText(openFile.FileName);
            }
        }
        #endregion

        #region Clear Text box
        /// <summary>
        /// This will clear the textbox when the file is closed, new file created and the text box needs to be cleared
        /// </summary>
        private void ClearInfo()
        {
            txtInformation.Clear(); // Clears the textbox
            SetSaveStatus(true); // changes save status to green
            ssFileName.Text = "--"; // Clears the File name
        }
        #endregion

        #region Text Change
        /// <summary>
        /// This will change the bottom left box to show that the textbox has been edited and you can lose changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditedText(object sender, EventArgs e)
        {
            SetSaveStatus(false); // Sets the save status to Edited because the text has changed in the textbox.
        }
        #endregion

        #region Disable Menu
        /// <summary>
        /// This will disable the menu from Lab 5 from transfering to the menu in lab 6.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisableMenu(object sender, EventArgs e)
        {
            msFile.Enabled = false;
            msEdit.Enabled = false;
            msHelp.Enabled = false;
            msFile.Visible = false;
            msEdit.Visible = false;
            msHelp.Visible = false;
        }
        #endregion

        #region BONUS: Confirm Close
        /// <summary>
        /// This will check if there is any changes that are not saved. if so, it will ask if you want to save before making changes.
        /// </summary>
        private void ConfirmClose()
        {
            if (ssSaveStatus.BackColor == Color.Red)
            {
                if (MessageBox.Show("You have changes that are not saved. Would you like to save?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveToFile(false);
                    ClearInfo();
                }
                else
                {
                    ClearInfo();
                }
            }
            else
            {
                ClearInfo();
            }
        }
        #endregion

        #endregion

        private void msFile_Click(object sender, EventArgs e)
        {

        }

        #region Closing the form
        private void Closed(object sender, FormClosedEventArgs e)
        {
            textInstance = null;
        }
        #endregion

        public void active(object sender, EventArgs e)
        {
            activeform = true;
        }

        public void notactive(object sender, EventArgs e)
        {
            activeform = false;
        }

        private void textchanged(object sender, EventArgs e)
        {
            SetSaveStatus(false); // Sets the save status to Edited because the text has changed in the textbox.
        }
    }
}
