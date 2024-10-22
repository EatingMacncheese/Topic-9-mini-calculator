using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_mini_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAnswer1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = "8 * 8 = " + (8 * 8);
            btnAdd.Enabled = false;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = "8 * 8 = " + (8 * 8);
            btnSub.Enabled = false;
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = "8 * 8 = " + (8 * 8);
            btnDivid.Enabled = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = "8 * 8 = " + (8 * 8);
            btnMultiply.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
