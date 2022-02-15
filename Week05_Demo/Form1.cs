using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week05_Demo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Global Variables
        const int MaxDimSize = 8;
        const int BlockSize = 80; // max size 80 pixels
        const int Gap = 5; // spaces between the boxes
        const int StartingX = 90;
        const int StartingY = 90;
        const int DefaultCellSize = 3;

        Label[,] colours; // Color is a type just like int or double


        #endregion

        #region Event Handlers        
        private void frmMain_Load(object sender, EventArgs e)
        {
            colours = new Label[MaxDimSize, MaxDimSize];
            this.nudNumCells.Value = DefaultCellSize; // Setting default of the number up down box
            this.nudNumCells.Minimum = 0; // Setting min of the number up down box
            this.nudNumCells.Maximum = MaxDimSize; // Setting max of the number up down box
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            ClearCells();
            //Create your swatches
            CreateSwatches(Convert.ToInt32(nudNumCells.Value));
        }


        #endregion

        #region Custom Methods
        private void SetDefaults()
        {
            this.nudNumCells.Value = DefaultCellSize; //This checks the Form and if the item exists. it wont cause a red line
            ClearCells();
        }

        private void ClearCells()
        {
            for (int y=0; y<MaxDimSize; y++)
            {
                for (int x = 0; x < MaxDimSize; x++)
                {
                    // Controls is a built in function that can add, remove controls on the form
                    this.Controls.Remove(colours[y,x]);
                }
            }    
            
            
        }

        private void CreateSwatches(int GridSize)
        {
            for (int y = 0; y < GridSize; y++)
            {
                for (int x = 0; x < GridSize; x++)
                {
                    // Controls is a built in function that can add, remove controls on the form
                    colours[x, y] = new Label();
                    colours[x, y].Name = "label: " + x.ToString() + y.ToString();
                    colours[x, y].Top = StartingY + y * (BlockSize + Gap);
                    colours[x, y].Left = StartingX + x * (BlockSize + Gap);
                    colours[x, y].Width = BlockSize;
                    colours[x, y].Height = BlockSize;
                    //colours[x, y].BackColor = Color.Red;
                    SetColour(colours[x, y]);

                    colours[x,y].Click += new System.EventHandler(this.LabelClicker);

                    this.Controls.Add(colours[x, y]);
                }
            }
            this.Width = 2 * StartingX + GridSize * (BlockSize + Gap) - Gap;
            this.Height = 2 * StartingY + GridSize * (BlockSize + Gap) - Gap;
        }

        private void LabelClicker(object sender, EventArgs e)
        {
            Label lab = (Label)Convert.ChangeType(sender, typeof(Label));
            SetColour(lab);
        }

        private void SetColour(Label l)
        {
            int red, green, blue, average;
            red = GetRandom(0, 255);
            green = GetRandom(0, 255);
            blue = GetRandom(0, 255);
            average = (red + green + blue) / 3;
            l.BackColor = Color.FromArgb(red, green, blue);
            l.Text = "(" + red.ToString() + ", " + green.ToString() + ", " + blue.ToString() + ")";
            if (average < 127)
                l.ForeColor = Color.White;
            else
                l.ForeColor = Color.Black;
        }

        private int GetRandom(int minNum, int maxNum)
        {
            Random r = new Random();
            return r.Next(minNum, maxNum);
        }


        #endregion
    }
}
