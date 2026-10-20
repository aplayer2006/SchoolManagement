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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
            display3();
        }

        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4ORKSF;Initial Catalog=schooldb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select count (*) from studentab", con);
            lblCount.Text = cnn.ExecuteScalar().ToString();
            con.Close();
        }

        private void display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4ORKSF;Initial Catalog=schooldb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select count (*) from subtab", con);
            lblCount1.Text = cnn.ExecuteScalar().ToString();
            con.Close();
        }

        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4ORKSF;Initial Catalog=schooldb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select count (*) from teachertab", con);
            lblCount2.Text = cnn.ExecuteScalar().ToString();
            con.Close();
        }

        private void display3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D4ORKSF;Initial Catalog=schooldb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select count (*) from entab", con);
            lblCount3.Text = cnn.ExecuteScalar().ToString();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (Program.currentUserRole == "Admin")
            {
                // Door opens! They are an admin.
                Users users = new Users();
                users.Show();
            }
            else
            {
                // Door stays locked! Stop them and show a warning.
                MessageBox.Show("Access Denied! Only admins can open this.");
            }
        }
    }
}
