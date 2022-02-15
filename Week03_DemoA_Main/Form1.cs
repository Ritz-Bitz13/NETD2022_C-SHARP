/*
 * Author: Martin Barber
 * Date Jan 25th, 2022
 * ID: 100368442
 * Title: NETD - Week 3 Section Demo
 * 
 * 
 */

// Region makes a collapsable Box
#region Using Section

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace Week03_DemoA_Main
{
    public partial class frmMain : Form
    {
        #region Main Function
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Clickable Events
        /// <summary>
        /// Click event for the add colour button, which adds the entered text to the available listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddColour_Click(object sender, EventArgs e)
        {
            if (dlgColourPicker.ShowDialog() == DialogResult.OK)
            {
                lbxAvailableColours.Items.Add(dlgColourPicker.Color);
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            // Adds the item in the Add colour text box
            // Trim Removes ANY spaces before or after the input for example ***red*** The 3 * (spaces) will be removed
            if (txtAddText.Text.Trim().Length >= 3)
            {
                //Adding the profanity Filter
                lbxAvailableColours.Items.Add(ProfanityFilter(txtAddText.Text.Trim()));
                // Clears Textbox
                txtAddText.Clear();
                // Focuses Textbox
                txtAddText.Focus();
            }
            else
            {
                MessageBox.Show("Invalid colour name, Try Again");
                // Highlights all characters in the textbox
                txtAddText.SelectAll();
                txtAddText.Clear();
                txtAddText.Focus();

            }
        }
        /// <summary>
        /// Adds the selected Item in available colours to the favourite Colours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // > 0 Means that if something is selected it is greater than 0 because it equils 1
            if (lbxAvailableColours.SelectedItems.Count > 0)
            {
                lbxFavColours.Items.Add(lbxAvailableColours.SelectedItem);
                lbxAvailableColours.Items.Remove(lbxAvailableColours.SelectedItem);
                SetOutput();
            }else
            {
                MessageBox.Show("There is no colours selected in the available list box");
            }
        }

        /// <summary>
        /// Removes selected from the favourites list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // > 0 Means that if something is selected it is greater than 0 because it equils 1
            if (lbxFavColours.SelectedItems.Count > 0)
            {
                lbxAvailableColours.Items.Add(lbxFavColours.SelectedItem);
                lbxFavColours.Items.Remove(lbxFavColours.SelectedItem);
                SetOutput();
            }
            else
            {
                MessageBox.Show("There is no colours selected in the Favourites list box");
            }
        }

        /// <summary>
        /// This will reset the form all to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// This will Exit the Application
        /// </summary>
        /// <param name="sender">End Program</param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Pulls up a message box to ask confirmation if you want to exit the program
            if (MessageBox.Show("Are you sure you want to quit?", "Exit Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Custom Methods

        /// <summary>
        /// Martin's Function resets all items to their default Values
        /// </summary>
        private void SetDefaults()
        {
            // Empty user input Boxes
            txtAddText.Clear();
            lblOutput.Text = string.Empty;
            lbxAvailableColours.Items.Clear();
            lbxFavColours.Items.Clear();

            // Set curser to default location
            txtAddText.Focus();
        }

        private void SetOutput()
        {
            string output = string.Empty;

            for (int i = 0; i < lbxFavColours.Items.Count; i++)
            {
                output = output + lbxFavColours.Items[i].ToString();
                // anything but the last item
                if (i < lbxFavColours.Items.Count - 1)
                {
                    output += ", ";
                }
            }
            lblOutput.Text = output;
        }

        #endregion
        // Profanity filter
        private string ProfanityFilter(string inputString)
        {
            string returnString = inputString;

            //a list of works to alter
            switch (inputString.Trim().ToLower())
            {
                case "shit":
                    returnString = "poop";
                    break;
                case "fuck":
                    returnString = "fudge";
                    break;
                default:
                    returnString = inputString;
                    break;

            }
            return returnString;
        }
        private void buttonWhile_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string outputString = "While - ";

            while (counter <= 10)
            {
                outputString += counter.ToString();

                // add a comma except for last one
                if (counter < 10)
                {
                    outputString += ", ";
                }

                counter++;
            }

            lblOutput.Text = outputString;

        }

        private void buttonDoWhile_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string outputString = "Do While - ";

            do
            {
                outputString += counter.ToString();
                // add a comma except for last one
                if (counter < 10)
                {
                    outputString += ", ";
                }
                counter++;
            } while (counter <= 10);

            lblOutput.Text = outputString;

        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            string outputString = "For Loop - ";

            for (int counter = 0; counter <= 10; counter++)
            {
                outputString += counter.ToString();
                if (counter < 10)
                {
                    outputString += ", ";
                }
            }

            lblOutput.Text = outputString;
        }
    }
}
