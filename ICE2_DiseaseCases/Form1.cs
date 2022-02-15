#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            Feb 3rd, 2022 - Feb 4th, 2022
 * Student ID:      100368442
 * Title: NETD:     ICE 02: Weekly Cases of Infections
 * Description:     This will count the total number of case each day to give a weekly average with the main program provided by Clint.
 */
#endregion

#region BUILT IN
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

#region Namespace, form1 public
namespace ICE2_DiseaseCases
{
    public partial class frmWeeklyCases : Form
    {
        public frmWeeklyCases()
        {
            InitializeComponent();
        }
        #endregion

        #region Global Variables
        // Global Variables
        Label[] weekDays;
        TextBox[] infections;
        //State a week for programming loops to do 7 days
        int oneWeek = 7;
        #endregion

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize the weekdays label array and populate with the appropriate labels
            weekDays = new Label[] { lblDay1, lblDay2, lblDay3, lblDay4, lblDay5, lblDay6, lblDay7 };

            // Create an array for each of the textboxes on the form
            infections = new TextBox[] { txtDay1, txtDay2, txtDay3, txtDay4, txtDay5, txtDay6, txtDay7 };


            // populate the week day name labels with the actual names.
            SetDayNames();

        }
        #endregion

        #region Set Day Names
        private void SetDayNames()
        {
            for (int day = 1; day <= 7; day++)
            {
                // This will set the date to the current date on the Computer. It then sets all the labels on the left to the days following.
                weekDays[day - 1].Text = (dtpStartingDate.Value.AddDays(day - 1)).DayOfWeek.ToString();
            }
        }
        #endregion

        #region Calculate Button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create the variables totalcases and average cases to be solved in the button press
            int totalCases = 0;
            int averageCases = 0;
            if (ValidateInfections())
            {
                // This will go through the text boxes array and add each box to the totalCases Varaible
                for (int w= 0; w < oneWeek; w++)
                {
                    totalCases += int.Parse(infections[w].Text.Trim());
                }
                // average = all the total cases divided by the amount of days in a week
                averageCases = totalCases / oneWeek;
                // Show answer on the lbl at the bottom
                lblDailyAverage.Text = averageCases.ToString();
            }
            else
            {
                // If calculations cant be done, show this message box to show that there is a problem.
                MessageBox.Show("Calculations can not be performed as one or more validations have failed");
            }
            
        }
        #endregion

        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit application
            Application.Exit();
        }
        #endregion

        #region Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Run the setDefaults to clear the form and reset the date
            SetDefaults();
        }
        #endregion

        #region Validation of inputs
        private bool ValidateInfections()
        {
            bool retVal = true;
            for (int d = 1; d <= 7; d++)
            {
                // Test each textbox in the array, if the number in the text box is not a number, fail and say what box has the problem
                int temp;
                if (int.TryParse(infections[d - 1].Text.Trim(), out temp))
                {
                    // If the number is negative, say so, clear the box and focus.
                    if (temp < 0)
                    {
                        retVal = false;
                        MessageBox.Show("Day: " + d + " can not be a negative number.");
                        infections[d - 1].Clear();
                        infections[d - 1].Focus();
                        break;
                    }
                    else
                    retVal = true;
                }
                else
                {
                    // If there is a textbox that does not meet requirements, this will say what box the problem is in.
                    retVal = false;
                    MessageBox.Show("Day: " + d + " has an invalid number.");
                    infections[d - 1].Clear();
                    infections[d-1].Focus();
                    break;
                }
            }
            return retVal;
        }
        #endregion

        #region Set All the Defaults
        private void SetDefaults()
        {
            // For each text box, the numbers will clear
            foreach (TextBox tBox in infections) { tBox.Clear(); }
            // Sets the DailyAverage lbl to 0.
            lblDailyAverage.Text = "0";
            // This will focus the first textbox to fill in the information
            txtDay1.Focus();
            for (int day = 1; day <= 7; day++)
            {
                weekDays[day - 1].Text = (dtpStartingDate.Value.AddDays(day - 1)).DayOfWeek.ToString();
            }
        }
        #endregion

        #region Date Change Refresh
        private void dtpStartingDate_ValueChanged(object sender, EventArgs e)
        {
            // When the Day selection is changed, The labels will auto-update now
            SetDayNames();
            // Once the date is changed, the information will all clear that has been input automatically
            SetDefaults();
            txtDay1.Focus();
        }
        #endregion
    }
}
