using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOnline
{
    public partial class Biography : Form
    {
        public Biography()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form frm = new Cinema();
            this.Hide();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new AmericanMade();
            this.Hide();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form frm = new Stronger();
            this.Hide();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new Wild();
            this.Hide();
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form frm = new TheDebtCollector();
            this.Hide();
            frm.Show();
        }
    }
}
