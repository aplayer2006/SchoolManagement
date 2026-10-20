using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4ORKSF;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();
            string query = "SELECT role FROM userstab WHERE  uid = @uid AND password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uid", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                
                Program.currentUserRole = result.ToString();

                MessageBox.Show("Login Successful!");
                Main dash = new Main();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }

            con.Close();
        }
    }
}
