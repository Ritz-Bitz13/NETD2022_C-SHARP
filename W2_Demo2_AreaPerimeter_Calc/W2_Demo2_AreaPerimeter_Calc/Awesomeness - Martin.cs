/* ----------------------------------
 * Author: Clint MacDonald
 * Date: 
 * Title: Week 2 - Demo 2 - Area and Perimeter Calclulator
 * Description:
 *      A basic application that calculates the area and 
 *      perimeter of a rectangle given the length and width
 * Revision History:
 *  1.0 - Initial Version (Clint MacDonald)
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

namespace W2_Demo2_AreaPerimeter_Calc
{
    public partial class Form1 : Form
    {
        const string ERROR_MESSAGE = "Error!";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Main Calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double length, width, area, perimeter;
            // check if values are valid
            if (double.TryParse(textLength.Text,out length) 
                    && 
                    double.TryParse(textWidth.Text, out width))
            {
                // calculations
                area = length * width;
                perimeter = 2 * length + 2 * width;
                // output
                textArea.Text = area.ToString();
                textPerimeter.Text = perimeter.ToString();
            }
            else
            {
                // at least one of length or perimeter are not valid numbers.
                textArea.Text = ERROR_MESSAGE;
                textPerimeter.Text = ERROR_MESSAGE;
            }
        }

        /// <summary>
        /// Reset form back to initial values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textLength.Text = string.Empty;
            textWidth.Text = string.Empty;
            textArea.Text = string.Empty;
            textPerimeter.Text = string.Empty;
            textLength.Focus();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
