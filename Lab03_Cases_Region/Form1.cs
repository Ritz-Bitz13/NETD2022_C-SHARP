#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            Feb 22nd, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 3: Regional Cases
 * Description:     This application will get 3 regions of their weekly numbers and get the averages of each
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 * 
 */
#endregion

#region using systems
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

namespace Lab03_Cases_Region
{
    public partial class frmRegionCases : Form
    {
        public frmRegionCases()
        {
            InitializeComponent();
        }

        #region Global variables and Arrays
        const int MaxCaseLimit = 7; // max number of cases available in each listbox
        const int MaxRegionLimit = 3; // 3 listboxes which means only 3 regions

        int[,] Cases; // the 2 dimentional Array

        int region = 0; // Start the region at 0, which wil be our 'x' for the 2 dimentional Array
        
        // Need each listbox has its own 'y' list for the array
        int region1Days = 0;
        int region2Days = 0;
        int region3Days = 0;

        // Each total of cases for each region to calculate the average
        double totalRegion1;
        double totalRegion2;
        double totalRegion3;
        
        #endregion

        #region Form Load Array
        private void frmRegionCases_Load(object sender, EventArgs e)
        {
            Cases = new int[MaxRegionLimit, MaxCaseLimit];
            
        }
        #endregion

        #region Enter Button
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Validation()) // If the validation does not catch the textbox with any problem it will continue and run the input
            { 
                int cases;
                double average;
                
                //When the program starts Region will be 0, which means it will enter this If statement to start counting in the first listbox
                if (region == 0)
                {
                    //as long as the number of items are less than the MaxCaseLimit (7) it will add more cases to that listbox
                    if (lbxRegion1.Items.Count != MaxCaseLimit)
                    {
                        cases = int.Parse(txtCases.Text.Trim());
                        //The array will get each number entered into the textbox and add it to the array
                        Cases[region, region1Days] = cases;
                        lbxRegion1.Items.Add(cases); //Adds the textbox number to the listbox
                        ClearInput();
                        region1Days++; // Adds 1 to region1Days variable to count up the array [0,0] to [0,6]
                    }
                    //Once there is 7 items in the list box, this if statement will run and will get the average for the first region
                    if (lbxRegion1.Items.Count == MaxCaseLimit)
                    {
                        average = 0;
                        for (int a = 0; a < MaxCaseLimit; a++)
                        {
                            totalRegion1 += Cases[region, a]; //run a for loop to add all the numbers from the array together
                        }
                        average = totalRegion1 / MaxCaseLimit; // calculate the average
                        average = Math.Round(average, 2); // Round to 2 decimal places
                        lblAverage1.Text = "Region 1: " + average.ToString(); // give result to label
                        region++; // Add 1 to region to start the second array
                    }
               


                }
                
                //When we start the second array this if statement will start collecting information to the second listbox and the next group of cases in the array
                else if (region == 1)
                {
                    if (lbxRegion2.Items.Count != MaxCaseLimit)
                    {
                        cases = int.Parse(txtCases.Text.Trim());
                        Cases[region, region2Days] = cases; // Array adds cases to [1,0] - [1,6]
                        lbxRegion2.Items.Add(cases); //enter case number to list box
                        // clears and resets the text box to get the next number
                        ClearInput();
                        region2Days++; // add 1 to region2days to get the next number for the array
                    }
                    if (lbxRegion2.Items.Count == MaxCaseLimit)
                    {
                        average = 0;
                        for (int b = 0; b < MaxCaseLimit; b++)
                        {
                            totalRegion2 += Cases[region, b]; // run a for loop to add all the numbers in the array together
                        }
                        average = totalRegion2 / MaxCaseLimit; // get average
                        average = Math.Round(average, 2); // round to 2 decimal places
                        lblAverage2.Text = "Region 2: " + average.ToString(); // place average number in the label
                        region++; // add 1 to region to go to the next array

                    }
                }

                else if (region == 2)
                {
                    if (lbxRegion3.Items.Count != MaxCaseLimit)
                    {
                        cases = int.Parse(txtCases.Text.Trim());
                        Cases[region, region3Days] = cases; // add to array [2,0] - [2-6]
                        lbxRegion3.Items.Add(cases); // adds number to the listbox 3
                        // clears and focus the textbox to get ready for the next case input
                        ClearInput();
                        region3Days++; // adds 1 to the day to count up the 'y' of the array
                    }


                    if (lbxRegion3.Items.Count == MaxCaseLimit)
                    {
                        double finalAverage = 0;
                        average = 0;
                        for (int c = 0; c < MaxCaseLimit; c++)
                        {
                            totalRegion3 += Cases[region, c]; // add all the numbers in the 3rd listbox together to calculate average
                        }
                        average = totalRegion3 / MaxCaseLimit;// calculate the average for the 3rd list box
                        average = Math.Round(average, 2); // round to 2 decimal places
                        lblAverage3.Text = "Region 3: " + average.ToString();; // write number to the label
                        btnEnter.Enabled = false; // disable enter button
                        txtCases.ReadOnly = true; // turn textbox at top to readonly so no information may be added


                        // Calculate the final average between all the regions
                        for (int x = 0; x < MaxRegionLimit; x++)
                        {
                            for (int y = 0; y < MaxCaseLimit; y++)
                            {
                                finalAverage += Cases[x, y]; // go through the entire array and add all the case numbers together
                            }
                        }
                        finalAverage = finalAverage / (MaxCaseLimit * MaxRegionLimit); // divide the total case numbers by the number of cases in each region * the number of regions
                        finalAverage = Math.Round(finalAverage, 2); // round to 2 decimal places
                        lblTotalAverage.Text = "All Regions Average: " + finalAverage.ToString(); // Write the number to the final label

                    }
                }

            }
        }
        #endregion

        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Reset Button Click
        /// <summary>
        /// This will reset everything in the application to factory new, all arrays, variables and information wiped from the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        #endregion

        #region Custom Functions

        #region Set Defaults Function
        /// <summary>
        /// Resets the list boxes, text boxes, Enter Button and Labels displaying the averages.
        /// </summary>
        private void SetDefaults()
        {
            // Clears all the Average labels to blank
            lblAverage1.Text = "";
            lblAverage2.Text = "";
            lblAverage3.Text = "";
            lblTotalAverage.Text = "";
            // Clears the textbox at the top, disables read only it and focuses after clearing
            txtCases.Clear();
            txtCases.ReadOnly = false;
            txtCases.Focus();
            // Clears the listboxes of all items.
            lbxRegion1.Items.Clear();
            lbxRegion2.Items.Clear();
            lbxRegion3.Items.Clear();
            // Re-enables the button if it has been disabled. if it isnt, this does nothing because the button is already enabled.
            btnEnter.Enabled = true; // re-enable the enter button if the app goes all the way through
            region = 0; // reset region to 0 for the start of the array
            // Each listbox gets a day counter to add up all the numbers together
            region1Days = 0;
            region2Days = 0;
            region3Days = 0;
            // If the total is calculate in the app and the user wants to input new information, everything will be wiped and there will be no old information
            totalRegion1 = 0;
            totalRegion2 = 0;
            totalRegion3 = 0;


        }
        #endregion

        #region FocusTextBox Function
        /// <summary>
        /// If there is an Error in the textbox when you click the enter button while verifying, This will select everything in the textbox and focus it
        /// </summary>
        private void FocusTextBox()
        {
            txtCases.SelectAll();
            txtCases.Focus();
        }
        #endregion

        #region Clear input
        /// <summary>
        /// This will clear the text box with the case numbers entered and refocus so you can enter a new input right away
        /// </summary>
        private void ClearInput()
        {
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
                        MessageBox.Show("Please enter a positive Number.", "Error"); // if number is outside the range, give this error
                        FocusTextBox();
                        return retVal;
                    }
                }
                else
                {
                    //If textbox has anything but a number in it, show this message box, Highlight the text box and refocus it
                    retVal = false;
                    // If there is any string characters entered, give this error or exceed the max amount of an int number.
                    MessageBox.Show("You did not enter an Int number. No decimals, words or numbers greater than 2,147,483,647 please.", "Error");
                    FocusTextBox();
                    return retVal;
                }
            }
            retVal = false;
            MessageBox.Show("You did not enter a number. Please enter a Case number.", "Error"); // If text box is blank and you hit enter, give this error.
            txtCases.Focus();
            return retVal;
        }
        #endregion

        #endregion

    }
}