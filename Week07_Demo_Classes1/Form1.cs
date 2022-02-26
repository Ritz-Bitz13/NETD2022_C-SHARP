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
            string tempDesig;
            tempDesig = lboxDroids.SelectedItem.ToString();
            PopulateDetails(tempDesig);
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
            Droid tempDroid = new Droid();
            tempDroid.Designation = this.txtDesignation.Text.Trim();
            tempDroid.Owner = this.txtOwner.Text.Trim();
            tempDroid.IsInService = this.chkInService.Checked;
            tempDroid.PrimaryColor = this.lblPrimaryColour.BackColor;
            tempDroid.SecondaryColor = this.lblSecondaryColour.BackColor;


            // add this droid to the global list
            Droid.Droids.Add(tempDroid);

            PopulateDroidList();

            //set everything to defaults once information is saved
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

        private void PopulateDroidList()
        {
            lboxDroids.Items.Clear();
            foreach (Droid d in Droid.Droids)
            {
                lboxDroids.Items.Add(d.Designation);
            }
        }

        private void PopulateDetails(string designation)
        {
            // Look through the LIST to find the specified droid designation
            // Create a new droid instance using that droid info
            // Fill in the form details
            Droid ourDroid = Droid.FindDroid(designation);
            

            this.lblDetailsDesignation.Text = ourDroid.Designation;
            this.chkDetailsInService.Checked = ourDroid.IsInService;
            this.lblDetailsOwner.Text = ourDroid.Owner;
            this.lblDetailsPrimaryColour.BackColor = ourDroid.PrimaryColor;
            this.lblDetailsSecondaryColour.BackColor = ourDroid.SecondaryColor;

            


        }

        #endregion

    }
}
