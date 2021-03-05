using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags_2
{
    public partial class frmFlags : Form
    {
        public frmFlags()
        {
            InitializeComponent();
        }

        private void picFinlandFlag_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Finland";
        }

        private void picFranceFlag_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "France";
        }

        private void picGermanyFlag_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Germany";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnChangeLabelColortoYellow_Click(object sender, EventArgs e)
        {
            lblCountry.BackColor = Color.Yellow;
        }

        private void btnChangeLabelColortoDefault_Click(object sender, EventArgs e)
        {
            lblCountry.BackColor = DefaultBackColor; 
        }

        private void btnChangeFomColortoGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue; 
        }

        private void btnChangeFormColortoDefault_Click(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor; 
        }

        private void btnHideFlags_Click(object sender, EventArgs e)
        {
            picFinlandFlag.Visible = false;
            picFranceFlag.Visible = false;
            picGermanyFlag.Visible = false; 
        }

        private void btnShowFlags_Click(object sender, EventArgs e)
        {
            picFinlandFlag.Show();
            picFranceFlag.Show();
            picGermanyFlag.Show(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrNumber1.Start();
        }

        private void tmrNumber1_Tick(object sender, EventArgs e)
        {
            picFinlandFlag.Show();
            picFranceFlag.Hide();
            picGermanyFlag.Hide();
            tmrNumber1.Stop();
            tmrNumber2.Start();

        }

        private void tmrNumber2_Tick(object sender, EventArgs e)
        {
            picFinlandFlag.Hide();
            picFranceFlag.Show();
            picGermanyFlag.Hide();
            tmrNumber2.Stop();
            tmrNumber3.Start();
        }

        private void tmrNumber3_Tick(object sender, EventArgs e)
        {
            picFinlandFlag.Hide();
            picFranceFlag.Hide();
            picGermanyFlag.Show();
            tmrNumber3.Stop();
            tmrNumber1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrNumber1.Stop();
            tmrNumber2.Stop();
            tmrNumber3.Stop();
            picFinlandFlag.Show();
            picFranceFlag.Show();
            picGermanyFlag.Show();
            lblCountry.Text = "";
            this.BackColor = DefaultBackColor;
            lblCountry.BackColor = DefaultBackColor; 
        }

        private void frmFlags_Load(object sender, EventArgs e)
        {

        }
    }
}
