using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo01_Temperature_Converter
{
    public partial class formMain : Form
    {

        const double CONVERT_MULTIPLIER = 1.8;
        const double CONVERT_ADDER = 32.0;

        public formMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit the program with a nice message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye!");

            MessageBox.Show("Clint was here","This is Clint's Caption",MessageBoxButtons.AbortRetryIgnore);

            /// Asking the user if they want to exit and if they say yes it will exit, if it says no, then the app continues
            if (MessageBox.Show("Do you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Reset the form back to initial settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textInputTemp.Text = string.Empty;
            textAnswer.Text = string.Empty;
            radioC.Checked = true;
            labelUnits.Text = "_";
         }

        /// <summary>
        /// Converts the input temperature from C to F or F to C based on input radio choices.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // variable declarations
            double inputValue = 0, outValue;

            // test if input value is a convertable number
            if (double.TryParse(textInputTemp.Text, out inputValue))
            {
                // if successful convert, then determine if C or F units
                if (radioC.Checked)
                {
                    // if C, the convert C to F
                    outValue = inputValue * CONVERT_MULTIPLIER + CONVERT_ADDER;
                    labelUnits.Text = "F";
                }
                else
                {
                    // else convert F to C
                    outValue = (inputValue - CONVERT_ADDER) / CONVERT_MULTIPLIER;
                    labelUnits.Text = "C";
                }
                textAnswer.Text = outValue.ToString();

            }
            else
            {
                // if convert fails, give error message
                textAnswer.Text = "Error!";
                textInputTemp.Focus();
                textInputTemp.SelectAll();
            }
        }
    }
}
