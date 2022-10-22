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
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
        }

        private void Cinema_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Action();
            this.Hide();
            frm.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Adventur();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Biography();
            this.Hide();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Sci_Fi();
            this.Hide();
            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Horror();
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new Comedy();
            this.Hide();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new Romance();
            this.Hide();
            frm.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Sport();
            this.Hide();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new War();
            this.Hide();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm = new Western();
            this.Hide();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string search;
            search = textBox1.Text;

            if (search == "BEAST OF BURDEN" || search == "CHINA SALESMAN" || search == "Tomb Raider" || search == "The Debt Collector" || search == "Negative" || search == "The Whisky Robber" || search == "Surrogates" || search == "Bullet")

            {
                Form frm = new Action();
                this.Hide();
                frm.Show();
            }

            else if (search == "Lara Croft Tomb Raider" || search == "Body of Sin" || search == "The Thousand Faces of Dunjia" || search == "The Hole")
            {
                Form frm = new Adventur();
                this.Hide();
                frm.Show();
            }

            else if (search == "American Made" || search == "Stronger" || search == "Wild" || search == "The Debt Collector")
            {
                Form frm = new Biography();
                this.Hide();
                frm.Show();
            }

            else if (search == "DEEP BLUE SEA 2" || search == "Maze Runner: The Death Cure" || search == "MAZINGER-Z- INFINITY")
            {
                Form frm = new Sci_Fi();
                this.Hide();
                frm.Show();
            }

            else if (search == "Apartament 212" || search == "A beginner's guide" || search == "The Revenge of Robert the Doll")
            {
                Form frm = new Horror();
                this.Hide();
                frm.Show();
            }

            else if (search == "Birthmarked" || search == "Jumanji" || search == "Hope of America")
            {
                Form frm = new Comedy();
                this.Hide();
                frm.Show();
            }

            else if (search == "Aşk Tesadüfleri Seve" || search == "Forever My Girl" || search == "New Life")
            {
                Form frm = new Romance();
                this.Hide();
                frm.Show();
            }

            else
            {
                Form frm = new Cinema();
                this.Hide();
                frm.Show();
            }


        }
    }
}
