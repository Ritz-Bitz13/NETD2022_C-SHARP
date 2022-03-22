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
    public partial class frmAddEdit : Form
    {
        Trooper currentTrooper;

        public frmAddEdit()
        {
            InitializeComponent();
            currentTrooper = new Trooper();
        }
        public frmAddEdit(Trooper t)
        {
            InitializeComponent();
            currentTrooper = new Trooper();
            currentTrooper = t;
            
        }

        List<String> Planets = new List<String>();


        #region Custom Methods
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
        #endregion

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            this.cboPlanets.DataSource = Planets;

            if (currentTrooper.Designation > 0) PopulateTrooper(currentTrooper); 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTrooper();
            SetDefaults();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            SaveTrooper();
            this.Close();
        }

        private void SaveTrooper()
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

            if (Trooper.TrooperExists(frmMain.Troopers, t.Designation))
            {
                Trooper FoundTrooper = Trooper.FindTrooper(frmMain.Troopers, t.Designation);
                frmMain.Troopers.Remove(FoundTrooper);
            }

            frmMain.Troopers.Add(t);
        }
    }
}
