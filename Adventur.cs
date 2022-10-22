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
    public partial class Adventur : Form
    {
        public Adventur()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form frm = new Cinema();
            this.Hide();
            frm.Show();
        }

        private void Adventur_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form frm = new TheHole();
            this.Hide();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new LaraCroftTombRaider();
            this.Hide();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form frm = new BodyOfSin();
            this.Hide();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new TheThousandFacesOfDunjia();
            this.Hide();
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form frm = new Negative();
            this.Hide();
            frm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form frm = new TheWhiskyRobber();
            this.Hide();
            frm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form frm = new Surrogates();
            this.Hide();
            frm.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form frm = new Outlander();
            this.Hide();
            frm.Show();
        }
    }
}
