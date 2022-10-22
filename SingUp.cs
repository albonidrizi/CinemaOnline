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
    public partial class SingUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VDCS7OI;Initial Catalog=SingUp;Integrated Security=True");

        public SingUp()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (textBox5.Text == "" || textBox6.Text == "")
                    MessageBox.Show("Please fill in the details ");


                else if (textBox6.Text != textBox7.Text)
                    MessageBox.Show("Password do not match!!");

            else
            {


                con.Open();

                SqlCommand sqlCmd = new SqlCommand("UserAddEdit", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(textBox8.Text == ""?"0" : textBox8.Text));
                sqlCmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", textBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", textBox6.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                
                MessageBox.Show("Registration is successfull");
                Form frm = new Login();
                this.Hide();
                frm.Show();

                Clear();
                con.Close();



            }

        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = ""; 
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }
    }
}
