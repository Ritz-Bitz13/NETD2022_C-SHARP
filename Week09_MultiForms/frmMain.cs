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
        #endregion
        
        private void PopulateUnits()
        {
            Units.Clear();
            Units.Add("Show All");
            Units.AddRange(Trooper.GetUniqueUnits(Troopers));

            this.cboUnits.DataSource = null;
            this.cboUnits.DataSource = Units;
        }

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
                }
            } 
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout();
            newForm.ShowDialog();
            newForm.Dispose();
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            DoSelectionChange = false;
            PopulateTroopers();
            DoSelectionChange = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit frmNew = new frmAddEdit();
            frmNew.ShowDialog();
            frmNew.Dispose();
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
            } else { }
            DoSelectionChange = true;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Trooper.FileWrite(Troopers, saveFileDialog1.FileName);
                MessageBox.Show("Save Complete", "Save Confirmation", MessageBoxButtons.OK);
            }

            //MessageBox.Show(saveFileDialog1.FileName);

        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Troopers.Clear();
                Troopers = Trooper.LoadFromCSV(openFileDialog1.FileName);
                DoSelectionChange = false;
                PopulateTroopers();
                DoSelectionChange = true;
            }
        }
    }
}
