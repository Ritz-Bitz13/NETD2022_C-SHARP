/* -----------------------
 * Author: Clint MacDonald
 * Date: June 2021
 * Title: Droid Factory - Class Example 1
 * ----------------------- */

#region USING
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

namespace W7_Demo_Classes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
        #endregion

        #region Control Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            lblPrimaryColour.BackColor = colorDialogMain.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            lblSecondaryColour.BackColor = colorDialogMain.Color;
        }

        private void lboxDroids_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
            // do stuff here first
            
            SetDefaults();
        }
        #endregion

        #region Custom UI Functions and Methods
        private void SetDefaults()
        {
            txtDesignation.Clear();
            txtOwner.Clear();
            chkInService.Checked = false;
            lblPrimaryColour.BackColor = Color.Gray;
            lblSecondaryColour.BackColor = Color.Gray;
        }

        #endregion

 
    }
}
