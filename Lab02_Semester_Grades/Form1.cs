#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            Feb 6th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 2: Semester Grades
 * Description:     This will allow the user to input their grades 0-100 and it gives back grade letter and you can calculate to get average.
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using Statements
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

namespace Lab02_Semester_Grades
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Global Variables and Arrays
        // GLOBAL VARIABLES & ARRAYS
        int minValue = 0;
        int maxValue = 100;
        // Array of all the textboxes
        TextBox[] gradesMark;
        // Array of all the labels
        Label[] gradesLetter;
        #endregion

        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // This will close the application
            Application.Exit();
        }
        #endregion

        #region Form Load Arrays
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Create an array for each of the textboxes on the form
            gradesMark = new TextBox[] { txtGrade1, txtGrade2, txtGrade3, txtGrade4, txtGrade5, txtGrade6, txtGrade7 };
            // Create an array for the grade letters to clear them when needed
            gradesLetter = new Label[] { lblGradeResult1, lblGradeResult2, lblGradeResult3, lblGradeResult4,
                lblGradeResult5, lblGradeResult6, lblGradeResult7, lblGradeResultSemester };
        }
        #endregion

        #region Calculate Button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidationCalculate()){
                // Local Variables
                double totalMarks= 0;
                int counter = 0;
                double Average;
                // Go through each textbox and test if there is a number. If there is, add it to the total.
                for (int g = 0; g < gradesMark.Length; g++)
                {
                    // If there is nothing written, it will skip
                    if (gradesMark[g].TextLength != 0)
                    {
                        // Add to variable totalMarks if the loop finds a value in a textbox
                        totalMarks += double.Parse(gradesMark[g].Text.Trim()); // adds the games for each player together.
                        // Counter to know exactly how many classes were put down in textboxes
                        counter++;
                    }
                    else
                        // If there is nothing written, skip the textbox
                        continue;
                }
                // Calculate the average from the total of the marks written down.
                // If counter = 0, ask the user to type in at least 1 grade
                if (counter != 0)
                {
                    // Convert the numbers to double to round to 2 decimal places
                    Average = Math.Round(Convert.ToDouble(totalMarks) / Convert.ToDouble(counter), 2);
                    // Print label to txtBox
                    txtSemesterAverage.Text = Average.ToString();
                    // Use Other Function that uses a Double instead of an int for the average to calculate to 2 decimal places
                    TestingSwitchFinal(Average, 7);
                    // Lock all the textboxes and Calculate button
                    Lock_Everything();
                }
                else
                    // Nothing has been entered. Alert the user and focus the first text box
                    lblProblems.Text = "Error - Please type in at least one grade";
                    txtGrade1.Focus();
                }
      
            

        }
        #endregion

        #region Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Runs SetDefaults to reset everything to start up
            SetDefaults();
            // Re-Enables all the textboxes and the calculate button
            Enable_Everything();
        }
        #endregion

        #region SetDefaults Function
        /// <summary>
        /// This will reset everything to Start-up of program
        /// </summary>
        private void SetDefaults()
        {
            // For each text box, the numbers will clear
            foreach (TextBox tBox in gradesMark) { tBox.Clear(); }
            // For each Label it will clear everything
            foreach (Label lbl in gradesLetter) { lbl.Text = ""; }
            txtSemesterAverage.Clear();
            // Clear the problems label if there is anything in it
            lblProblems.Text = "";
            // Set focus to the first textbox you can input your grade to
            txtGrade1.Focus();
        }
        #endregion

        #region Testing the Grades & Final Average
        /// <summary>
        /// This Does the exact same thing as TestingSwitch except for the value it calculate is a double, not an int.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="labloop"></param>
        private void TestingSwitchFinal(double i, int labloop)
        {
            switch (i)
            {
                case < 50.0:
                    gradesLetter[labloop].Text = "F";
                    break;
                case < 52.0:
                    gradesLetter[labloop].Text = "D-";
                    break;
                case < 58.0:
                    gradesLetter[labloop].Text = "D";
                    break;
                case < 60.0:
                    gradesLetter[labloop].Text = "D+";
                    break;
                case < 62.0:
                    gradesLetter[labloop].Text = "C-";
                    break;
                case < 68.0:
                    gradesLetter[labloop].Text = "C";
                    break;
                case < 70.0:
                    gradesLetter[labloop].Text = "C+";
                    break;
                case < 72.0:
                    gradesLetter[labloop].Text = "B-";
                    break;
                case < 78.0:
                    gradesLetter[labloop].Text = "B";
                    break;
                case < 80.0:
                    gradesLetter[labloop].Text = "B+";
                    break;
                case < 82.0:
                    gradesLetter[labloop].Text = "A-";
                    break;
                case < 90.0:
                    gradesLetter[labloop].Text = "A";
                    break;
                case <= 100.0:
                    gradesLetter[labloop].Text = "A+";
                    break;
            }
        }
        #endregion

        #region Validation of Textboxes
        /// <summary>
        /// Validation will check the specified textbox to make sure the input grade is within the specified Parameters. Uses 'TestingSwitch' Function.
        /// </summary>
        /// <param name="boxnum">textbox number here</param>
        private void Validation(int boxnum)
        {
            {
                double number;
                // Clear the lblProblems before it tests
                lblProblems.Text = string.Empty;
                // If the txtBox is empty, skip everything, if not, run the check
                if (gradesMark[boxnum-1].TextLength != 0)
                {
                    // Test to see if the input in the textbox is a number
                    if (double.TryParse(gradesMark[boxnum-1].Text.Trim(), out number))
                    {
                        // Once the first check has been done, Check to see if the number is within range
                        if (number < 0 || number > 100)
                        {
                            // If number is not within range, give error, select the textbox and focus it.
                            lblProblems.Text = "Error - Your grade in Course " + (boxnum) + " should be between 0 and 100";
                            gradesMark[boxnum-1].SelectAll();
                            gradesMark[boxnum-1].Focus();
                        }
                        else
                            // If the grade entered passed all the checks, run the Select Case to see what the grade it
                            // Running the function with the number that was given, the second number is the label array number.
                            // Since each label incriments by 1, the number is the same as the textbox number, the function will
                            // fix to match the array
                            TestingSwitchFinal(number, boxnum-1);
                    }
                    else
                    {
                        // This will ask you to fix the problem if you type in a string
                        lblProblems.Text = "Error - Course " + (boxnum) + ": Please enter your grade. Do not enter letters or symbols.";
                        gradesMark[boxnum-1].SelectAll();
                        gradesMark[boxnum-1].Focus();
                    }
                }
            }
        }
        #endregion

        #region Bool Inputs (Sorry i used your code)

        private bool IsNumeric(string inputValue, int minValue, int maxValue)
        {
            bool retVal = true;
            double temp;
            if (double.TryParse(inputValue, out temp))
            {
                if (!(IsInRange(temp, minValue, maxValue))) { retVal = false; }
            }
            else
            {
                retVal = false;
            }
            return retVal;
        }

        private bool IsInRange(double inputValue, int minValue, int maxValue)
        {
            return (inputValue >= minValue && inputValue <= maxValue);
        }

        private bool ValidationCalculate()
        {
            bool retVal = true;
            for (int g = 1; g <= 7; g++)
            {
                if (!(IsNumeric(gradesMark[g - 1].Text.Trim(), minValue, maxValue))) //IsNumeric 
                {
                    // If the textbox is highlight but nothing is in it, skip
                    if (gradesMark[g-1].Text.Length == 0)
                    {
                        continue;
                    }
                        if (retVal)
                        {   
                            //This tells the user what textbox is wrong
                            lblProblems.Text = "Wrong input on Course " + g;
                        }
                    retVal = false;
                }
            }
            return retVal;
        }
        #endregion

        #region TextBoxs: Leave Events
        private void txtGrade1_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the first textbox
            Validation(1);
        }
      
        private void txtGrade2_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the second textbox
            Validation(2);
        }

        private void txtGrade3_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the third textbox
            Validation(3);
        }

        private void txtGrade4_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the fourth textbox
            Validation(4);
        }

        private void txtGrade5_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the fifth textbox
            Validation(5);
        }

        private void txtGrade6_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the sixth textbox
            Validation(6);
        }

        private void txtGrade7_Leave(object sender, EventArgs e)
        {
            // Uses validation function for the seventh textbox
            Validation(7);
        }
        #endregion

        #region Lock and Enable functions
        private void Lock_Everything()
        {
            // Goes through the function and locks every textbox & the calculate button
            for (int g = 1; g <= gradesMark.Length; g++)
            {
                gradesMark[g-1].Enabled = false;
            }
            // Disable the calculate button
            btnCalculate.Enabled = false;
        }

        private void Enable_Everything()
        {
            // Goes through the function and unlocks every textbox that was previously locked
            for (int g = 1; g <= gradesMark.Length; g++)
            {
                gradesMark[g - 1].Enabled = true;
            }
            // Enable the calculate button
            btnCalculate.Enabled = true;
        }
        #endregion
    }
}