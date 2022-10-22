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
    public partial class Western : Form
    {
        public Western()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form frm = new Cinema();
            this.Hide();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new TombRaider();
            this.Hide();
            frm.Show();
        }
    }
}
