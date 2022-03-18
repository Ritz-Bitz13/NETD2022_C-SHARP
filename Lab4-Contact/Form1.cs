


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #endregion

        private void frmContactTracing_Load(object sender, EventArgs e)
        {
            Contacts = ContactTracing.GetSampleContacts();
            PopulateContacts();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            ContactTracing c = new ContactTracing();
            lblErrors.Text = ""; // Clears the Error Text box so if you have constant errors it does not stack

            if (txtFirstName.TextLength <2)
            {
                lblErrors.Text += "Please enter the first name.";
                txtFirstName.Focus();
                txtFirstName.SelectAll(); // Focus and highlights the error
                isValid = false;
            }else
                c.FirstName = this.txtFirstName.Text.Trim(); // Add First name to the form

            if (txtLastName.TextLength <2)
            {
                lblErrors.Text += "\nPlease enter the last name.";
                txtLastName.Focus();
                txtLastName.SelectAll();
                isValid = false;
            }
            else
                c.LastName = this.txtLastName.Text.Trim(); // Add Last name to the form

            if (!CheckEmail())
            {
                lblErrors.Text += "\nPlease enter a proper email";
                txtEmail.Focus();
                txtEmail.SelectAll();
                isValid = false;
            }
            else
                c.Email = this.txtEmail.Text.Trim();

            if (!CheckPhoneNumber())
            {
                lblErrors.Text += "\nPlease enter a proper phone number";
                txtPhone.Focus();
                txtEmail.SelectAll();
                isValid = false;
            }
            else
                c.Phone = this.txtPhone.Text.Trim();

            

            if (isValid)
            {
                // Contacted does not need to be validated because it is a check box
                c.Contacted = this.chkContacted.Checked; //DateTime is automatic so does not need to be validated
                c.Date = DateTime.Now; //
                Contacts.Add(c); // Once you have all the information, add it to the list.
                PopulateContacts(); // Refresh the grid to add the new value.
                SetDefaults();
            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

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

        private void PopulateContacts()
        {
            this.dgvTracing.ClearSelection(); // if you have anything selected it will deselect it
            this.dgvTracing.DataSource = null; // Set the datasource to nothing
            this.dgvTracing.DataSource = Contacts; // Reload the list and the form will have the new updated list if a new value was added
            this.dgvTracing.ClearSelection(); // have it after because it will automatically select the first from in the databox.
        }

        private bool CheckPhoneNumber()
        {
            bool retVal = true;
            double tempNumber;
            if (txtPhone.TextLength == 10)
            {
                if (double.TryParse(txtPhone.Text.Trim(), out tempNumber))
                    {
                    if (tempNumber > 0)
                    {
                        retVal = true;
                        return retVal;
                    }
                    else
                        retVal = false;
                }
                else
                    retVal = false;
            }
            retVal = false;
            return retVal;
        }

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
                    retVal = true;
                    return retVal;
                }
                else
                    retVal = false;
            }
            else
                retVal = false;

            return retVal;
        }
            

    }
}
