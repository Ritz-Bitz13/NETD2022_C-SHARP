using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Cases_Region
{
    public partial class frmRegionCases : Form
    {
        public frmRegionCases()
        {
            InitializeComponent();
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

        /// <summary>
        /// If there is an Error in the textbox when you click the enter button while verifying, This will select everything in the textbox and focus it
        /// </summary>
        private void FocusTextBox()
        {
            txtCases.SelectAll();
            txtCases.Focus();
        }

        /// <summary>
        /// This will Validate the input text box to input casess. If there is something entered that isnt right, this will catch it.
        /// </summary>
        private void Validation()
        {
            int tempNumber;
            if (txtCases.TextLength == 0)
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
                MessageBox.Show("Please enter a number in the text box to input it to the region");
                FocusTextBox();
        }
    }
}