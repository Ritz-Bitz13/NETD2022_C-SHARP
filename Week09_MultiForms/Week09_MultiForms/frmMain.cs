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
        List<String> Planets = new List<String>();

        public static List<Trooper> Troopers = new List<Trooper>();

        Boolean DoSelectionChange = true;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            cboPlanets.DataSource = Planets;
            Troopers = Trooper.GetSampleTroopers();
            DoSelectionChange = false;
            PopulateTroopers();
            DoSelectionChange = true;
        }

        private void btnSetHairColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblHairColour.BackColor = colorDialog1.Color;
        }

        private void btnSetEyeColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblEyeColour.BackColor = colorDialog1.Color;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion

        #region CUSTOM METHODS
        private void PopulatePlanets()
        {
            Planets.Add("Alderaan");
            Planets.Add("Bespin");
            Planets.Add("Coruscant");
            Planets.Add("Dagobah");
            Planets.Add("Endor");
            Planets.Add("Geonosis");
            Planets.Add("Hoth");
            Planets.Add("Jakku");
            Planets.Add("Kamino");
            Planets.Add("Mandalore");
            Planets.Add("Mustafar");
            Planets.Add("Naboo");
            Planets.Add("Scarif");
            Planets.Add("Tatooine");
            Planets.Add("Yavin");
        }

        private void SetDefaults()
        {
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }

        private void PopulateTroopers()
        {
            this.dgvClones.ClearSelection();
            this.dgvClones.DataSource = null;
            this.dgvClones.DataSource = Troopers;
            this.dgvClones.ClearSelection();

            dgvClones.Columns[2].Width = 250;

            this.cboUnits.DataSource = null;
            this.cboUnits.DataSource = Trooper.GetUniqueUnits(Troopers);

        }
        #endregion

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Trooper t = new Trooper();
            t.Designation = decimal.ToInt32(this.nudDesignation.Value);
            t.NickName = this.txtNickName.Text.Trim();
            t.Unit = this.txtUnit.Text.Trim();
            t.IsDefective = this.chkDefective.Checked;
            t.HairColor = this.lblHairColour.BackColor;
            t.EyeColor = this.lblEyeColour.BackColor;
            t.HomeWorld = this.cboPlanets.SelectedValue.ToString();
            t.Born = this.dtpBorn.Value;

            if (Trooper.TrooperExists(Troopers, t.Designation))
            {
                Trooper FoundTrooper = Trooper.FindTrooper(Troopers, t.Designation);
                Troopers.Remove(FoundTrooper);
            }

            Troopers.Add(t);
            PopulateTroopers();
            SetDefaults();
        }

        private void dgvClone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClones.SelectedRows.Count > 0)
            {
                int selectedDesignation = Convert.ToInt32(dgvClones.SelectedRows[0].Cells[0].Value);
                Trooper t = Trooper.FindTrooper(Troopers, selectedDesignation);
                PopulateTrooper(t);

                if (DoSelectionChange)
                {
                    frmAddEdit newF = new frmAddEdit(t);
                    newF.ShowDialog();
                    newF.Dispose();
                    
                }

            } else
            {
                SetDefaults();
            }
        }

        private void PopulateTrooper(Trooper t)
        {
            this.nudDesignation.Value = t.Designation;
            this.txtNickName.Text = t.NickName;
            this.txtUnit.Text = t.Unit;
            this.chkDefective.Checked = t.IsDefective;
            this.lblHairColour.BackColor = t.HairColor;
            this.lblEyeColour.BackColor = t.EyeColor;
            this.cboPlanets.SelectedItem = t.HomeWorld;
            this.dtpBorn.Value = t.Born;
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
    }
}
