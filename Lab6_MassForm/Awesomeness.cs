/* ----------------------------------
 * Author: Martin Barber
 * Date: Jan 20th, 2022
 * Title: ICE01
 * Description:
 *      This application will show that I am awesome, obviously
 *      Also, if the user tries to attempt to click no, the button 
 *      will 'jump' away from the user.
 * -----------------------------------
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

namespace Lab6_MassForm
{
    public partial class frmAwesomeness : Form
    {
        public frmAwesomeness()
        {
            InitializeComponent();
        }

        //This will only allow 1 of the forms to be open at the same time.
        private static frmAwesomeness AwesomeInstance;
        public static frmAwesomeness Instance
        {
            get
            {
                if (AwesomeInstance == null)
                    AwesomeInstance = new frmAwesomeness();
                return AwesomeInstance;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // When the YEs button is clicked, a message box will pop up and say that I am indeed awesome. then close the program
            MessageBox.Show("Yes, Martin Barber is awesome, aren't they!");
            this.Close();
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
            // Checks to see if the Button No is at pixel 100.
            if (btnNo.Left == 100)
            {
                // If button IS at 100, move it to 240
                btnNo.Left = 240;
            }
            else
            {
                // If the button has moved and is located at the 240 pixel point, move it back to the 100 pixel point
                btnNo.Left = 100;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheater! Using Alt + N (Or ESC) is just mean!", "You Cheated!");
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            AwesomeInstance = null;
        }
    }
}
