/*
 * Author:          Martin Barber
 * Date:            March 15th, 2022
 * Student ID:      100368442
 * Title: NETD:     About Form Page connected to Multiform Week 09
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09_Multiforms
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // This will close that the button is running on. Since it is running on the About form, it will close said form
        }
    }
}
