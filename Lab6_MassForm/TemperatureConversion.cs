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
    public partial class frmTemperature : Form
    {

        const double CONVERT_MULTIPLIER = 1.8;
        const double CONVERT_ADDER = 32.0;

        private static frmTemperature temperatureInstance;

        public static frmTemperature Instance
        {
            get
            {
                if (temperatureInstance == null)
                    temperatureInstance = new frmTemperature();
                return temperatureInstance;
            }
        }

        public frmTemperature()
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
            this.Close();
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

        #region Closing the form, only 1 allowed
        private void Closed(object sender, FormClosedEventArgs e)
        {
            temperatureInstance = null;
        }
        #endregion
    }
}
