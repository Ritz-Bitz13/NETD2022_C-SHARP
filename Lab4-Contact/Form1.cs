#region App Created by:
/*
 * Author:          Martin Barber
 * Date:            March 13th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 4: Contact Tracing
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using
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

namespace Lab4_Contact
{
    public partial class frmContactTracing : Form
    {
        public frmContactTracing()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS

        List<ContactTracing> Contacts = new List<ContactTracing>();
        bool isValid = true;
        int ID = 4;
        int count = 4;

        #endregion

        #region Form Load
        private void frmContactTracing_Load(object sender, EventArgs e)
        {
            Contacts = ContactTracing.GetSampleContacts();
            PopulateContacts();
        }
        #endregion

        #region Enter Button
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            ContactTracing c = new ContactTracing();
            lblErrors.Text = ""; // Clears the Error Text box so if you have constant errors it does not stack

            // If the first name is a single character or blank, it will cause an error
            if (txtFirstName.TextLength <2)
            {
                lblErrors.Text += "Please enter the first name.";
                txtFirstName.Focus();
                txtFirstName.SelectAll(); // Focus and highlights the error
                isValid = false;
            }else
                c.FirstName = this.txtFirstName.Text.Trim(); // Add First name to the form

            // If the first name is a single character or blank, it will cause an error
            if (txtLastName.TextLength <2)
            {
                lblErrors.Text += "\nPlease enter the last name.";
                txtLastName.Focus();
                txtLastName.SelectAll();
                isValid = false;
            }
            else
                c.LastName = this.txtLastName.Text.Trim(); // Add Last name to the form

            // If CheckEmail() does not pass, it will give an error
            if (!CheckEmail())
            {
                lblErrors.Text += "\nPlease enter a proper email, 'example_email@live.ca' for example";
                txtEmail.Focus();
                txtEmail.SelectAll();
                isValid = false;
            }
            else
                c.Email = this.txtEmail.Text.Trim();// If validation is successful, add to class

            // if CheckPhoneNumber() does not pass, it will show an error.
            if (!CheckPhoneNumber())
            {
                lblErrors.Text += "\nPlease enter a proper phone number: '9055551234' for example.";
                txtPhone.Focus();
                txtPhone.SelectAll();
                isValid = false;
            }
            else
                c.Phone = this.txtPhone.Text.Trim(); // If validation is successful, add to class


            // If Everything is Validated, Add the rest of the variables and populate the new contact to the Data Grid View
            if (isValid)
            {
                c.Contacted = this.chkContacted.Checked; //DateTime is automatic so does not need to be validated
                c.Date = DateTime.Now; //Receives the date and time the information was entered.
                c.ID = ID;
                c.Count = count;
                // Contacted does not need to be validated because it is a check box
                Contacts.Add(c); // Once you have all the information, add it to the list.
                PopulateContacts(); // Refresh the grid to add the new value.
                dgvTracing.Columns[0].Visible = false; // This will hide the count Column in the dgvTracing.
                SetDefaults();
                ID++; // Add to ID for the next unique input
                count++; //  add to the count for the amount of peop
            }            
        }
        #endregion

        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit application
        }
        #endregion

        #region Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaults(); // set everything back to default values
        }
        #endregion

        #region Custom Methods / Functions

        #region SetDefaults
        /// <summary>
        /// This will reset all the text boxes, focus the first name textbox and clear the selection of the contact information grid.
        /// </summary>
        private void SetDefaults()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            chkContacted.Checked = false;
            txtFirstName.Focus();
            this.dgvTracing.ClearSelection();
        }
        #endregion

        #region PopulateContacts
        /// <summary>
        /// This will populate the information on the grid of all the patients information
        /// </summary>
        private void PopulateContacts()
        {
            this.dgvTracing.ClearSelection(); // if you have anything selected it will deselect it
            this.dgvTracing.DataSource = null; // Set the datasource to nothing
            this.dgvTracing.DataSource = Contacts; // Reload the list and the form will have the new updated list if a new value was added
            this.dgvTracing.ClearSelection(); // have it after because it will automatically select the first from in the databox.
        }
        #endregion

        #region CheckPhoneNumber Validation
        /// <summary>
        /// This Validation checks to make sure the phone number that was entered was in fact a number and 10 digits.
        /// </summary>
        /// <returns></returns>
        private bool CheckPhoneNumber()
        {
            bool retVal = true;
            double tempNumber;
            string phoneNumber;

            if (txtPhone.TextLength == 10) // make sure there are 10 characters in the textbox
            {
                if (double.TryParse(txtPhone.Text.Trim(), out tempNumber)) // check to make sure there is no letters in the phone number
                    {
                    phoneNumber = tempNumber.ToString(); // convert number to a string to check if there is a decimal.
                    if (phoneNumber.Contains(".")) // If the string contains a decimal, fail the check
                    {
                        retVal = false;
                    }
                    else
                    {
                    if (tempNumber > 0) // If the number isnt negaive, pass the check.
                        {
                            retVal = true;
                            return retVal;
                        }
                        else
                            retVal = false;
                    }
                        
                }
                else
                    retVal = false;
            }
            retVal = false;
            return retVal;
        }
        #endregion

        #region CheckEmail Validation
        /// <summary>
        /// This validates the email textbox to make sure there is a proper email entered to the form.
        /// </summary>
        /// <returns></returns>
        private bool CheckEmail()
        {
            bool retVal = true;
            string input;

            input = txtEmail.Text; // Create a variable from the textbox to be able to compare
            if (input.Contains(".com") || input.Contains(".ca") && input.Contains("@")) // Check for the main requirements for an email
            {
                // Check further into the domain of the email
                if (input.Contains("hotmail") || input.Contains("gmail") || input.Contains("live") || input.Contains("outlook"))
                {
                    retVal = true; // If all checks pass, the validation passes.
                    return retVal;
                }
                else
                    retVal = false;
            }
            else
                retVal = false;

            return retVal;
        }
        #endregion

        #region SelectionChanged
        /// <summary>
        /// If the user selects one of the contacts, It will fill the information in the text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTracing_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTracing.SelectedRows.Count > 0)
            {
                //  in datagrid, the first row selected [0], then in that row the first cell (designation) get the value.
                int selectedDesignation = Convert.ToInt32(dgvTracing.SelectedRows[0].Cells[0].Value);
                ContactTracing c = ContactTracing.GetStatus(Contacts, selectedDesignation);
                FillContact(c);
            }
            else
            {
                SetDefaults();
            }
        }
        #endregion

        #region Selected Contact Fill information
        /// <summary>
        /// This function is used if the user selects one of the contacts in the data grid view, it will populate the information to the textboxes.
        /// </summary>
        /// <param name="c"></param>
        private void FillContact(ContactTracing c)
        {
            this.txtFirstName.Text = c.FirstName;
            this.txtLastName.Text = c.LastName;
            this.txtPhone.Text = c.Phone;
            this.txtEmail.Text = c.Email;
            this.chkContacted.Checked = c.Contacted;
        }
        #endregion

        #endregion
    }
}
