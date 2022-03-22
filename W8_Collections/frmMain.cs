#region Program Written By:
/*
 * Author:          Martin Barber & Clint MacDonald
 * Date:            March 8th, 2022
 * Student ID:      100368442
 * Title: NETD:     Week 8: Collections
 * Description:     
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week08_Collections
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<String> Planets = new List<String>(); //The planet list in the drop down box

        List<Trooper> Troopers = new List<Trooper>();

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
            cboPlanets.DataSource = Planets; // Brings the list into the form. (Combobox)
            Troopers = Trooper.GetSampleTroopers();

            PopulateTroopers();
            //this.dgvClones.DataSource = Troopers;     // this adds the default values to the data grid view
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
            this.dgvClones.ClearSelection(); // if you have anything selected it will deselect it
            this.dgvClones.DataSource = null; // Set the datasource to nothing
            this.dgvClones.DataSource = Troopers; // Reload the list and the form will have the new updated list if a new value was added
            this.dgvClones.ClearSelection(); // have it after because it will automatically select the first from in the databox.

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
            t.Born = this.dtpBorn.Value;
            t.HomeWorld = this.cboPlanets.SelectedValue.ToString(); //Make sure you use Selected Value, NOT SELECTED ITEM!!!!!

            if (Trooper.TrooperExists(Troopers, t.Designation))
            {
                Trooper FoundTrooper = Trooper.FindTrooper(Troopers, t.Designation);
                Troopers.Remove(FoundTrooper);
            }
            Troopers.Add(t);

            // Once you have all the information, add it to the list
            
            PopulateTroopers();

            // Refresh the grind to add the new value
            SetDefaults();
        }

        private void dgvClone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClones.SelectedRows.Count > 0)
            {
                //  in datagrid, the first row selected [0], then in that row the first cell (designation) get the value.
            int selectedDesignation = Convert.ToInt32(dgvClones.SelectedRows[0].Cells[0].Value);
            Trooper t = Trooper.FindTrooper(Troopers, selectedDesignation);
            PopulateTrooper(t);
            }else
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
            this.dtpBorn.Value = t.Born;
            this.cboPlanets.SelectedItem = t.HomeWorld;
        }
    }
}
