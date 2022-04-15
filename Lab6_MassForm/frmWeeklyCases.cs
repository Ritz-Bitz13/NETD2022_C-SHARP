#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            Jan 28th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 1: Weekly Cases of COVID
 * Description:     This will count the total number of case each day to give a weekly average
 */
#endregion

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

namespace Lab6_MassForm
{
    public partial class frmCases : Form
    {
        public frmCases()
        {
            InitializeComponent();
        }

        #region Single Form Instance
        private static frmCases CasesInstance;

        public static frmCases Instance
        {
            get
            {
                if (CasesInstance == null)
                    CasesInstance = new frmCases();
                return CasesInstance;
            }
        }
        #endregion

        #region Global Variables
        const int MaxCaseLimit = 7;
        int[] Cases = new int[MaxCaseLimit];
        int counter = 0;
        #endregion

        #region Enter Button
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int cases;
            lblAverageCases.Text = ""; // clears the label
            if (Validation())
            {
                cases = int.Parse(txtCases.Text.Trim());
                Cases[counter] = cases; // add the number to the array.
                lbxWeeklyCases.Items.Add(cases); // adds the number from the textbox to the listbox
                ResetInput();
                counter++; // adds to the counter for the array / day counter
                if (counter < MaxCaseLimit)
                    lblDay.Text = "Day: " + (counter + 1); // adds a day to the counter
            }

            if (counter == MaxCaseLimit)
            {
                int total = 0;
                double average = 0;
                btnEnter.Enabled = false; // disable the button
                txtCases.Enabled = false; // The textbox becomes disabled so you cant type into it
                for (int a = 0; a < MaxCaseLimit; a++)
                {
                    total += Cases[a]; //run a for loop to add all the numbers from the array together
                }
                average = (double)total / MaxCaseLimit; // calculates the average.
                average = Math.Round(average, 2); // Round to 2 decimal places
                lblAverageCases.Text = "Weekly Average: " + average; // Posts the average to the label
            }

        }
        #endregion

        #region Exit Button
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // close the application
            this.Close();
        }
        #endregion

        #region Reset Button
        private void ClearForm(object sender, EventArgs e)
        {
           ResetWeekly();
        }
        #endregion

        #region Custom Methods

        #region Reset Weekly Cases
        /// <summary>
        /// This function will reset everything to default (how the program starts)
        /// </summary>
        private void ResetWeekly()
        {
            
            // Enable the enter button and changes textbox back from readonly if it is in that state.
            btnEnter.Enabled = true;
            txtCases.Enabled = true;
            counter = 0;
            // Clears the textbox is there is any information in the box
            txtCases.Clear();
            // Deletes all information in the list box
            lbxWeeklyCases.Items.Clear();
            // Clears the Average cases label if there is anything written
            lblAverageCases.Text = string.Empty;
            // Resets the day to Sunday
            lblDay.Text = "Day: " + (counter+1);
            // Focus the curser to the Cases text box to input new variables
            txtCases.Focus();
        }
        #endregion

        #region Reset Input
        /// <summary>
        /// This will reset the cases txt input and focus it again for the next input.
        /// </summary>
        private void ResetInput()
        {
            // CLears the txtbox and puts curser focus back on the box.
            txtCases.Clear();
            txtCases.Focus();
        }
        #endregion

        #region Validation Function
        /// <summary>
        /// This will Validate the input text box to input casess. If there is something entered that isnt right, this will catch it.
        /// </summary>
        private bool Validation()
        {
            bool retVal = true;
            int tempNumber;
            if (txtCases.TextLength != 0)
            {
                if (int.TryParse(txtCases.Text.Trim(), out tempNumber))
                {
                    // If number is less than 0 or higher then an allowed Int number
                    if (tempNumber >= 0) // Max number an Int can go, if anyhigher it can crash.
                    {
                        retVal = true;
                        return retVal;
                    }
                    else
                    {
                        //If the textbox has a negative number, show an error
                        retVal = false;
                        lblAverageCases.Text = "Please enter a positive Number."; // if number is outside the range, give this error
                        ResetInput();
                        return retVal;
                    }
                }
                else
                {
                    //If textbox has anything but a number in it, show this message box, Highlight the text box and refocus it
                    retVal = false;
                    // If there is any string characters entered, give this error or exceed the max amount of an int number.
                    lblAverageCases.Text = "You did not enter a number. No decimals or letters";
                    ResetInput();
                    return retVal;
                }
            }
            retVal = false;
            lblAverageCases.Text = "You did not enter anything. Please enter a number."; // If text box is blank and you hit enter, give this error.
            txtCases.Focus();
            return retVal;
        }
        #endregion

        #endregion

        #region Closing the form
        private void Closed(object sender, FormClosedEventArgs e)
        {
            CasesInstance = null;
        }
        #endregion
    }


}