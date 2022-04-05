using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09_MultiForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        public static List<Trooper> Troopers = new List<Trooper>();
        public static List<String> Units = new List<String>();

        Boolean DoSelectionChange = true;
        Boolean DoUnitUpdate = true;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Troopers = Trooper.GetSampleTroopers();
            DoSelectionChange = false;
            PopulateTroopers();
            DoSelectionChange = true;
            SetSaveStatus(true);
        }


        #endregion

        #region CUSTOM METHODS
        
        private void PopulateTroopers()
        {
            this.dgvClones.ClearSelection();
            this.dgvClones.DataSource = null;
            this.dgvClones.DataSource = Troopers;
            this.dgvClones.ClearSelection();

            dgvClones.Columns[2].Width = 250;

            if (DoUnitUpdate) PopulateUnits();

        }

        private void SaveToFile(Boolean saveAs)
        {
            //TODO: SaveAs with existing filename
            if (!saveAs && ssFileName.Text.Length > 4)
            {
                Trooper.FileWrite(Troopers, ssFileName.Text); // If we have a file name we will use the name of that file
                MessageBox.Show("Save Complete", "Save Confirmation", MessageBoxButtons.OK);
            }
            else
            {
                // If we do not have a file name, then it will create one
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Trooper.FileWrite(Troopers, saveFileDialog1.FileName);
                    MessageBox.Show("Save Complete", "Save Confirmation", MessageBoxButtons.OK);
                    this.ssFileName.Text = saveFileDialog1.FileName;
                }
            }
            SetSaveStatus(true);
        }

        private void PopulateUnits()
        {
            Units.Clear();
            Units.Add("Show All");
            Units.AddRange(Trooper.GetUniqueUnits(Troopers));

            this.cboUnits.DataSource = null;
            this.cboUnits.DataSource = Units;
        }

        private void SetSaveStatus(Boolean isSaved)
        {
            if (isSaved)
            {
                this.ssSaveStatus.BackColor = Color.Green;
                this.ssSaveStatus.Text = "Saved";
            }
            else
            {
                this.ssSaveStatus.BackColor = Color.Red;
                this.ssSaveStatus.Text = "Edited";
            }
        }

        #endregion

        private void dgvClone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClones.SelectedRows.Count > 0)
            {
                int selectedDesignation = Convert.ToInt32(dgvClones.SelectedRows[0].Cells[0].Value);
                Trooper t = Trooper.FindTrooper(Troopers, selectedDesignation);

                if (DoSelectionChange)
                {
                    frmAddEdit newF = new frmAddEdit(t);
                    newF.ShowDialog();
                    newF.Dispose();
                    SetSaveStatus(false);   // TODO: HANDLE CANCEL BUTTON
                }
            } 
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            DoSelectionChange = false;
            PopulateTroopers();
            DoSelectionChange = true;
        }

        private void cboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoSelectionChange = false;
            if (cboUnits.SelectedIndex > 0)
            {
                
                String selectedUnit = cboUnits.SelectedValue.ToString();
                this.dgvClones.DataSource = null;
                this.dgvClones.DataSource = Trooper.GetUnitTroopers(Troopers, selectedUnit);
                
            }
            else if (cboUnits.SelectedIndex == 0)
            {
                DoUnitUpdate = false;
                PopulateTroopers();
                DoUnitUpdate = true;
            } 
            else { }

            DoSelectionChange = true;
        }

        #region MenuItems
        private void msHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout();
            newForm.ShowDialog();
            newForm.Dispose();
        }

        private void msFileSave_Click(object sender, EventArgs e)
        {
            SaveToFile(false);
        }
        
        private void msFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveToFile(true);
        }

        private void msFileClose_Click(object sender, EventArgs e)
        {
            Troopers.Clear();
            DoSelectionChange = false;
            PopulateTroopers();
            DoSelectionChange = true;
            SetSaveStatus(true);
            ssFileName.Text = "--";
        }

        private void msFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void msFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Troopers.Clear();
                Troopers = Trooper.LoadFromCSV(openFileDialog1.FileName);
                DoSelectionChange = false;
                PopulateTroopers();
                DoSelectionChange = true;

                this.ssFileName.Text = openFileDialog1.FileName;  // User can see the file name with this code.
                SetSaveStatus(true);
            }
        }
        private void msFileAddTrooper_Click(object sender, EventArgs e)
        {
            frmAddEdit frmNew = new frmAddEdit();
            frmNew.ShowDialog();
            frmNew.Dispose();
            SetSaveStatus(false);  //TODO: HANDLE CANCEL BUTTON
        }

        #endregion

       
    }
}
