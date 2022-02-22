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

        private void frmRegionCases_Load(object sender, EventArgs e)
        {

        }

        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Reset Button Click
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
            btnEnter.Enabled = true;

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

        #region Validation Function
        /// <summary>
        /// This will Validate the input text box to input casess. If there is something entered that isnt right, this will catch it.
        /// </summary>
        private void Validation()
        {
            int tempNumber;
            if (txtCases.TextLength != 0)
            {
                if (int.TryParse(txtCases.Text.Trim(), out tempNumber))
                {
                    if (tempNumber < 0)
                    {
                        //TODO: ENTER THE VERIFICATION TO ADD IT TO THE REGION LIST BOX WITH 2 DIMENSIONAL ARRAY
                        
                    }
                    else
                    {
                        //If the textbox has a negative number, show an error
                        MessageBox.Show("Please enter a positive Number.");
                        FocusTextBox();
                    }
                }
                else
                {
                    //If textbox has anything but a number in it, show this message box, Highlight the text box and refocus it
                    MessageBox.Show("You did not enter a number. Please enter an Integer! No decimals or words please.");
                    FocusTextBox();
                }
            }
            else
                //If there is nothing written in the textbox, a message box will appear telling you to enter information
                MessageBox.Show("Please enter a number in the text box to input it to the region");
                FocusTextBox();
        }
        #endregion

        #endregion

        private void lblTotalAverage_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lbxRegion1.Items.Add("123");
            lbxRegion1.Items.Add("234");
            lbxRegion1.Items.Add("345");
            lbxRegion1.Items.Add("456");
            lbxRegion1.Items.Add("567");
            lbxRegion1.Items.Add("678");
            lbxRegion1.Items.Add("789");

            lbxRegion2.Items.Add("123");
            lbxRegion2.Items.Add("234");
            lbxRegion2.Items.Add("345");
            lbxRegion2.Items.Add("456");
            lbxRegion2.Items.Add("567");
            lbxRegion2.Items.Add("678");
            lbxRegion2.Items.Add("789");

            lbxRegion3.Items.Add("123");
            lbxRegion3.Items.Add("234");
            lbxRegion3.Items.Add("345");
            lbxRegion3.Items.Add("456");
            lbxRegion3.Items.Add("567");
            lbxRegion3.Items.Add("678");
            lbxRegion3.Items.Add("789");

        }
    }
}