using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaOnline
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VDCS7OI;Initial Catalog=SingUp;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string select = "Select * from SingUp Where Username = '" + textBox1.Text.Trim() + "' and Password ='" + textBox2.Text.Trim() + "' ";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form frm = new Cinema();
                this.Hide();
                frm.Show();

            }
            else
            {
                linkLabel1.Text = ("You forgot the password , please try again!!!");
            }

            con.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

     

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new SingUp();
            this.Hide();
            frm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
