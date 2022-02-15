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

namespace Lab_1_Cases
{
    public partial class frmCases : Form
    {
        public frmCases()
        {
            InitializeComponent();
        }

        #region Public Variables
        // Making a public variable so when the number is entered it stores the information for later.
        public int CASESCOUNT1, CASESCOUNT2, CASESCOUNT3, CASESCOUNT4, CASESCOUNT5, CASESCOUNT6, CASESCOUNT7;
        #endregion

        #region Enter Click Button
        private void btnEnter_Click(object sender, EventArgs e)
        {
            #region Day 1
            // Checks to see how many Items are in the list Box.
            if (lbxWeeklyCases.Items.Count == 0)
            {
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT1))
                {
                    // checks if the number now checked is a positive number
                    if (CASESCOUNT1 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT1);
                        //Resets the txtbox & focuses it
                        ResetInput();
                        // changes the label in top right to the next day
                        lblDay.Text = "Day: Monday";
                    }
                    else
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                }
                
                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion
            #region Day 2
            // Checks to see how many Items are in the list Box.
            else if (lbxWeeklyCases.Items.Count == 1)
            {
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT2))
                {
                    // checks if the number now checked is a positive number
                    if (CASESCOUNT2 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT2);
                        //Resets the txtbox & focuses it
                        ResetInput();
                        // changes the label in top right to the next day
                        lblDay.Text = "Day: Tuesday";
                    }
                    else
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                }

                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion
            #region Day 3
            // Checks to see how many Items are in the list Box.
            else if (lbxWeeklyCases.Items.Count == 2)
            {
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT3))
                {
                    // checks if the number now checked is a positive number
                    if (CASESCOUNT3 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT3);
                        //Resets the txtbox & focuses it
                        ResetInput();
                        // changes the label in top right to the next day
                        lblDay.Text = "Day: Wednesday";
                    }
                    else
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                }

                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion
            #region Day 4
            // Checks to see how many Items are in the list Box.
            else if (lbxWeeklyCases.Items.Count == 3)
            {
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT4))
                {
                    // checks if the number now checked is a positive number
                    if (CASESCOUNT4 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT4);
                        //Resets the txtbox & focuses it
                        ResetInput();
                        // changes the label in top right to the next day
                        lblDay.Text = "Day: Thursday";
                    }
                    else
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                }

                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion
            #region Day 5
            // Checks to see how many Items are in the list Box.
            else if (lbxWeeklyCases.Items.Count == 4)
            {
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT5))
                {
                    // checks if the number now checked is a positive number
                    if (CASESCOUNT5 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT5);
                        //Resets the txtbox & focuses it
                        ResetInput();
                        // changes the label in top right to the next day
                        lblDay.Text = "Day: Friday";
                    }
                    else
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                }

                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion
            #region Day 6
            // Checks to see how many Items are in the list Box.
            else if (lbxWeeklyCases.Items.Count == 5)
            {
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT6))
                {
                    // checks if the number now checked is a positive number
                    if (CASESCOUNT6 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT6);
                        //Resets the txtbox & focuses it
                        ResetInput();
                        // changes the label in top right to the next day
                        lblDay.Text = "Day: Saturday";
                    }
                    else
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                }

                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion
            #region Final Day
            // Checks to see how many Items are in the list Box.
            else if (lbxWeeklyCases.Items.Count == 6)
            {
                int totalCases;
                double averageCases;
                // Checks to see if the input in the text box is a number or anything else. If anything else, it will fail and show a message box
                // If the check passes, Store the value given into a global variable to be used at the end for average
                if (int.TryParse(txtCases.Text.Trim(), out CASESCOUNT7))
                {
                    if (CASESCOUNT7 >= 0)
                    {
                        // Adds item to the Listbox
                        lbxWeeklyCases.Items.Add(CASESCOUNT7);
                        // Sets the Week as complete
                        lblDay.Text = "Completed Form";
                        // Clears the textbox
                        txtCases.Clear();
                        //Disables the enter button and textbox to enter more numbers.
                        txtCases.Enabled = false;
                        btnEnter.Enabled = false;
                        // Takes all global variables and adds them to a total
                        totalCases = CASESCOUNT1 + CASESCOUNT2 + CASESCOUNT3 + CASESCOUNT4 + CASESCOUNT5 + CASESCOUNT6 + CASESCOUNT7;
                        // divides the total cases by 7 to get the average for the week
                        averageCases = totalCases / 7;
                        // Displays information in the label below the  listbox
                        lblAverageCases.Text = averageCases.ToString() + " Cases on Average ";
                    }
                    else
                    {
                        // show a messagebox that says the number is invalid because its negative
                        MessageBox.Show("Invalid Number. Please enter a number 0 or greater");
                        ResetInput();
                    }
                }
                else
                {
                    // show a messagebox and clear the information if the input is invalid
                    MessageBox.Show("Invalid input. Please enter a number");
                    ResetInput();
                }
            }
            #endregion

        }
        #endregion

        #region Exit Button
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
        #endregion

        #region Reset Button
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            SetDefaults();
        }
        #endregion

        #region Functions used throughout the program
        /// <summary>
        /// This function will reset everything to default (how the program starts)
        /// </summary>
        private void SetDefaults()
        {
            // Enable the enter button and changes textbox back from readonly if it is in that state.
            btnEnter.Enabled = true;
            txtCases.Enabled = true;

            // Clears the textbox is there is any information in the box
            txtCases.Clear();
            // Deletes all information in the list box
            lbxWeeklyCases.Items.Clear();
            // Clears the Average cases label if there is anything written
            lblAverageCases.Text = string.Empty;
            // Resets the day to Sunday
            lblDay.Text = "Day: Sunday";

            // Focus the curser to the Cases text box to input new variables
            txtCases.Focus();

        }

        /// <summary>
        /// This will reset the cases txt input and focus it again for the next input.
        /// </summary>
        private void ResetInput()
        {
            // CLears the txtbox and puts curser focus back on the box.
            txtCases.Clear();
            txtCases.Focus();
        }

    }
    #endregion

}