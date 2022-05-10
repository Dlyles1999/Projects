using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class tipTitle : Form
    {
        public tipTitle()
        {
            InitializeComponent();
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            double milesTraveled;
            double gasUsed;
            double MPG;
            gasUsed = double.Parse(txtbxGallon.Text);
            milesTraveled = double.Parse(txtbxMiles.Text);
            MPG = milesTraveled / gasUsed;
            lblResult.Text = "The Miles Per Gallon is: " + MPG.ToString();

            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbxDestination.Clear();
            txtbxGallon.Clear();
            txtbxMiles.Clear();
            lblResult.Text = "";
             
        }
    }
}
