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

        #endregion

        private void frmContactTracing_Load(object sender, EventArgs e)
        {
            Contacts = ContactTracing.GetSampleContacts();
            PopulateContacts();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

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
        }

        private void PopulateContacts()
        {
            this.dgvTracing.ClearSelection(); // if you have anything selected it will deselect it
            this.dgvTracing.DataSource = null; // Set the datasource to nothing
            this.dgvTracing.DataSource = Contacts; // Reload the list and the form will have the new updated list if a new value was added
            this.dgvTracing.ClearSelection(); // have it after because it will automatically select the first from in the databox.
        }
    }
}
