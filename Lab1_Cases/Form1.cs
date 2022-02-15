/*
 * Author:          Martin Barber
 * Date:            Jan 28th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 1: Weekly Cases
 */

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

namespace Lab1_Case
{
    public partial class frmWeeklyCases : Form
    {
        public frmWeeklyCases()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int casesCount, Total, casesAverage;
            if (int.TryParse(txtcasesCount.Text.Trim(), out casesCount))
            {
                lbxWeeklyCases.Items.Add(casesCount);

                 txtcasesCount.Clear();
                 txtcasesCount.Focus();
                
            }

            // calculations adding the cases together

             else
             {
                 MessageBox.Show("Invalid input. Please enter a number");
                 txtcasesCount.Clear();
                 txtcasesCount.Focus();
             }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// This function will reset everything to default (how the program starts)
        /// </summary>
        private void SetDefaults()
        {
            // Clears the textbox is there is any information in the box
            txtcasesCount.Clear();
            // Deletes all information in the list box
            lbxWeeklyCases.Items.Clear();
            // Clears the Average cases label if there is anything written
            lblAverageCases.Text = string.Empty;

            // Enable the enter button and changes textbox back from readonly if it is in that state.
            btnEnter.Enabled = true;
            txtcasesCount.ReadOnly = false;

            // Focus the curser to the Cases text box to input new variables
            txtcasesCount.Focus();

        }
    }


}
