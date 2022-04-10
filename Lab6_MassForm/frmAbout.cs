#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            Jan 28th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 1: Weekly Cases of COVID
 * Description:     This will count the total number of case each day to give a weekly average
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

namespace Lab6_MassForm
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
