/* ----------------------------------
 * Author:  Clint MacDonald
 * Date:    May 24, 2021
 * Description:
 *      A sample application that takes a bowling teams scores and 
 *      performs calculations with data validation functions
 * Revision History:
 *      1.0     May 24, 2021        Clint MacDonald         Initial Version
 * ----------------------------------
 */

#region USING STATEMENTS
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

namespace w4_demo1_BowlingTeam
{
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLE DECLARATIONS

        const int MaxPlayers = 4;
        const int MaxGames = 3;
        const int MinScore = 0;
        const int MaxScore = 300;

        string[] randomPlayerNames;
        TextBox[] playerNames;
        TextBox[,] scores;
        Label[] playerTotals;


        //string[] myArrayofStrings = new string[6];

        //private myfabc()
        //{
        //  myArrayofStrings[0] = "Clint";
        //  myArrayofStrings[1] = "Bob";
        //}

        // int[,] myIntArray = new int[4, 5];   2 dementional array

        #endregion

        #region EVENT HANDLERS

        private void formMain_Load(object sender, EventArgs e)
        {
            playerNames = new TextBox[] { textBoxName1, textBoxName2, textBoxName3, textBoxName4 };
            scores = new TextBox[,] {   { textBoxScoreP1G1, textBoxScoreP1G2, textBoxScoreP1G3 },
                                        { textBoxScoreP2G1, textBoxScoreP2G2, textBoxScoreP2G3 },
                                        { textBoxScoreP3G1, textBoxScoreP3G2, textBoxScoreP3G3 },
                                        { textBoxScoreP4G1, textBoxScoreP4G2, textBoxScoreP4G3 } };
            playerTotals = new Label[] { labelTotalP1, labelTotalP2, labelTotalP3, labelTotalP4 };
            SetDefaults();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // before performing calculations,
            // validate that all data is entered correctly
            int highScore = MaxScore*MaxGames;
            int lowScore = MinScore;
            int totalScore = 0; //LAB MISTAKE!!! STATE NUMBER = SOMETHING.
            int[] totalScores = new int[MaxPlayers];

            if (ValidateNames() && ValidateScores())
            {
                // set the total array values to 0 to start
                for (int i = 0; i < MaxPlayers; i++) { totalScores[i] = 0; }

                // calculations
                // iterate through each player
                for (int p = 0; p < MaxPlayers; p++)
                {
                    // for each player interate throguh the games
                    for (int g = 0; g < MaxGames; g++)
                    {
                        totalScores[p] += int.Parse(scores[p, g].Text.Trim()); // adds the games for each player together.
                    }

                    // output total to players label
                    playerTotals[p].Text = totalScores[p].ToString();

                    // now we have label totals checks
                    if (lowScore > totalScores[p]) { lowScore = totalScores[p]; }
                    if (highScore < totalScores[p]) { highScore = totalScores[p]; }
                    // track the overall total
                    totalScore += totalScores[p];
                }

                // now we can calcualte averages and team score
                double avgScore = Math.Round(Convert.ToDouble(totalScore) / Convert.ToDouble(MaxPlayers), 2);
                double teamScore = Math.Round(Convert.ToDouble(totalScore-lowScore)/ Convert.ToDouble(MaxPlayers -1), 2);

                // output
                labelLowScore.Text = lowScore.ToString();
                labelTopScore.Text = highScore.ToString();
                labelAverageScore.Text = avgScore.ToString();
                labelTeamScore.Text = teamScore.ToString();

            }
            else
            {
                MessageBox.Show("Calculations can not happen as values might be incorrect!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion

        #region CUSTOM METHODS AND FUNCTIONS

        #region DATA VALIDATION
        private bool ValidateNames()
        {
            bool retVal = true; //RetVal = Return Value...bool = true or false (yes or no) (1 or 0) 
            int counter = 1;
            foreach (TextBox tBox in playerNames)
            {
                if (tBox.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Player " + counter.ToString() + "'s name is invalid");
                    retVal = false;
                    break;
                }
                counter++;
            }

            return retVal;
        }

        private bool ValidateScores()
        {
            bool retVal = true;
            // iterate through players
            for (int p = 1; p <= MaxPlayers; p++)
            {
                // for each player we need to iterate through games
                for (int g = 1; g <= MaxGames; g++)
                {
                       if (!(IsNumeric(scores[p-1,g-1].Text.Trim(), MinScore, MaxScore))) //IsNumeric 
                       {
                         if (retVal)
                            {
                                MessageBox.Show("Score " + g + " for player " + p + " is invalid");
                            }
                            retVal = false;
                        }
                }
            }
            return retVal;
        }

        private bool IsNumeric(string inputValue)
        {
            double temp;
            return double.TryParse(inputValue, out temp);
        }

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


        #endregion

        #region GENERAL METHODS

        private void SetDefaults()
        {
            foreach (TextBox tBox in playerNames) { tBox.Clear(); } //Clears all the PlayerNames Textboxes
            foreach (TextBox tBox in scores) { tBox.Clear(); } //Clears all the Scores Textboxes
            foreach (Label lbl in playerTotals) { lbl.Text = "0"; }
            labelLowScore.Text = "0";
            labelTopScore.Text = "0";
            labelTeamScore.Text = "0";
            labelAverageScore.Text = "0";
        }
        #endregion

        #region TESTING METHODS

        private void buttonTestValues_Click(object sender, EventArgs e)
        {
            randomPlayerNames = new string[] { "Joe", "Bob", "Sally", "Jennifer", "Lee", "Jim", "Raj", 
                "Darren", "Stephen", "x", " ", "    s" };  // 1 dementional array!!! can make unlimited names but randomizes
            populateItems();
        }

        private void populateItems()
        {
            // names
            foreach (TextBox tBox in playerNames)
            {
                tBox.Text = randomPlayerNames[GetRandom(0, randomPlayerNames.Length - 1)];  //[min, max] numbers you want
            }

            // scores
            foreach (TextBox tBox in scores)
            {
                tBox.Text = GetRandom(MinScore, MaxScore).ToString(); //Randomizes the Scores between 0 and 300
            }
        }


        private int GetRandom(int minNum, int maxNum)
        {
            Random r = new Random();
            return r.Next(minNum, maxNum);
        }


        #endregion

        #endregion
      
    }
}
