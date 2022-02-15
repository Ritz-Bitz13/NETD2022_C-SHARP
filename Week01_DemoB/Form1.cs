using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week01_DemoB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ///Declare Variables to get txt boxes
            int numX, numY, answer;
            ///Try: test to see if the txt box has a number in it
            if (int.TryParse(txtX.Text, out numX))
            {
                ///Try: Test to see if the txt box Y has a number in it
                if (int.TryParse(txtY.Text, out numY))
                {
                    ///if both variables have a number in it, calculates it and gives answer
                    answer = numX + numY;
                    lblAnswer.Text = answer.ToString();
                }
                else
                    ///If txtY doesnt have a number, show error
                    lblAnswer.Text = "Error in Y";
            } else
            {
                ///If txtX doesnt have a number, show error
                lblAnswer.Text = "Error in X";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ///This will execute the SetDefault 
            SetDefault();
        }

        private void SetDefault()
        {
            ///Better form of emptying a text box, proper form
            txtX.Text = string.Empty;
            ///Best form to clear a text box
            txtY.Clear();
            ///only way to clear a label
            lblAnswer.Text= string.Empty;
            ///Move Curser to X box (Back to the starting Position)
            txtX.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ///Closes the whole application
            Application.Exit();
        }
    }
}
