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
    public partial class Sci_Fi : Form
    {
        public Sci_Fi()
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
            Form frm = new DeepBlueSea();
            this.Hide();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form frm = new MazeRunner();
            this.Hide();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new MAZINGER();
            this.Hide();
            frm.Show();
        }
    }
}
