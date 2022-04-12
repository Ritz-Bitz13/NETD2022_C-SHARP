#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            March 9th, 2022
 * Student ID:      100368442
 * Title: NETD:     ICE 04 - Classes
 * Description:     
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using Systems
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
    public partial class frmFavouriteGame : Form
    {
        public frmFavouriteGame()
        {
            InitializeComponent();
        }

        #region Global Variables
        List<String> Consoles = new List<String>(); // List for the Consoles Combo Box
        List<String> Moments = new List<String>(); // List for the Favourites Combo Box

        List<Games> Game = new List<Games>(); // List for the games being put into the list

        bool isValid = true; // Checking validation. If isValid is false, there is a problem with the information being put in.
        #endregion

        #region Form Load
        /// <summary>
        /// When the form loads is has to place the combo box information into the drop down box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFavouriteGame_Load(object sender, EventArgs e)
        {
            PopulateConsole(); // Populate the Console Combo Box
            PopulateFavourite(); // Populate the Favourites combo Box
            cboConsole.DataSource = Consoles; // Get data from the Consoles List
            cboFavourite.DataSource = Moments; // Get data from Favourite moments List

            Game = Games.GetSampleGames(); // Displays the 3 sample games to make sure the Grid displays the information properly
            PopulateGames(); // Populates the datagrid view.
        }
        #endregion

        #region Reset Button
        /// <summary>
        /// Resets the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        #endregion

        #region Save Button
        /// <summary>
        /// When you hit save, if all the inputs are done properly then a new game will be inserted into the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            Games g = new Games();

            // Could not get the list checking for designation....
            g.Designation = decimal.ToInt32(this.nudDesignation.Value); // Gets the designation of the game. have to convert from a decimal to int because a numeric up down is a decimal.

            /*************************** Game Name Validation **********************/
            if (txtName.TextLength < 2 || txtName.Text.Trim() =="") // Text must be at least 2 characters long and text cant be empty
            {
                MessageBox.Show("Please enter a game Title to add to the list", "Error in Game Name");
                isValid = false; // set isValid to false so it does not add the game to the list
            }else
            {
                g.GameName = this.txtName.Text.Trim(); // Gets the name of the game in the textbox
            }

            /*************************** Console Validation **********************/
            if (cboConsole.SelectedValue == null)
            {
                MessageBox.Show("Please select the console you played the game on.", "Error in Console");
                isValid = false;
            }else
            {
                g.Console = this.cboConsole.SelectedValue.ToString(); // Checks what console was selected in the combo box.
            }


            /*************************** Favourite Validation **********************/
            if (cboFavourite.SelectedValue == null)
            {
                MessageBox.Show("Please select your favourite part of the game.", "Error in Favourites");
                isValid = false;
            }
            else
            {
                g.Favourite = this.cboFavourite.SelectedValue.ToString(); // Checks what items was selected in the Favourite combo box
            }

            // DataValidation not needed. Its checked or not. simple
            g.Replayable = this.cbxReplay.Checked; //Checks to see if the checkbox is checked
            
            // If there is a fail in the validation, the new data will not add.
            if (isValid) 
            {
                Game.Add(g); // Adds the new game to the last
                PopulateGames(); // Populates the list on the Data Grid View
                SetDefaults(); //Cleans the input boxes so the user can enter new information if they want to add another game to their list
            }
            
        }
        #endregion

        #region Custom Methods

        #region Set Defaults
        /// <summary>
        /// Resets everyhting to a blank screen for new inputs
        /// </summary>
        private void SetDefaults()
        {
            nudDesignation.Value = 1; //Resets Designation Value to 0
            txtName.Clear(); // Clears txt Box
            cboConsole.SelectedIndex = -1; // Resets combo box
            cboFavourite.SelectedIndex = -1;// Resets combo box
            cbxReplay.Checked = false; // Unchecks replay if it is checked
            nudDesignation.Focus(); // Focuses up down box to start next input
        }
        #endregion

        #region Console used List
        /// <summary>
        /// This will be all the selections in the combo box for Consoles
        /// </summary>
        private void PopulateConsole()
        {
            Consoles.Add("PC");
            Consoles.Add("Xbox");
            Consoles.Add("Xbox 360");
            Consoles.Add("Xbox Series S");
            Consoles.Add("Xbox One");
            Consoles.Add("Playstation");
            Consoles.Add("PlayStation 2");
            Consoles.Add("PlayStation 3");
            Consoles.Add("PlayStation 4");
            Consoles.Add("PlayStation 5");
            Consoles.Add("Nintendo Wii");
            Consoles.Add("Nintendo Switch");
            Consoles.Add("Nintendo GameCube");
            Consoles.Add("Nintendo 64");
            Consoles.Add("Super Nintendo");
            Consoles.Add("Sega");
        }
        #endregion

        #region Favourite Part List
        /// <summary>
        /// This will be the list of items you can select for your favourite part in the game
        /// </summary>
        private void PopulateFavourite()
        {
            Moments.Add("Storyline");
            Moments.Add("Action");
            Moments.Add("Boss Battles");
            Moments.Add("Puzzles");
            Moments.Add("Combat");
            Moments.Add("Character Develpment");
            Moments.Add("Weapons");
            Moments.Add("Constant Laughs");
        }
        #endregion

        #region Populate Games
        /// <summary>
        /// This will clear the Data Grid and insert it again with any new information that was placed.
        /// </summary>
        private void PopulateGames()
        {
            this.dgvGames.ClearSelection();
            this.dgvGames.DataSource = null;
            this.dgvGames.DataSource = Game;
            this.dgvGames.ClearSelection();
        }
        #endregion

        #endregion
    }
}
