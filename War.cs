﻿using System;
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
    public partial class War : Form
    {
        public War()
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
            Form frm = new BeastOfBurden();
            this.Hide();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form frm = new ChinaSalesman();
            this.Hide();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new TombRaider();
            this.Hide();
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form frm = new TheDebtCollector();
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
            Form frm = new Bullet();
            this.Hide();
            frm.Show();
        }
    }
}
