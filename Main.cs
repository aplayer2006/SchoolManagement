using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            LoadFormIntoPanel(student);
        }

        private void LoadFormIntoPanel(Form subForm)
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls[0].Dispose();
            }

            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(subForm);
            subForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            LoadFormIntoPanel(student);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            LoadFormIntoPanel(subject);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            LoadFormIntoPanel(teacher);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            LoadFormIntoPanel(section);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            LoadFormIntoPanel(enrollment);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            LoadFormIntoPanel(attendance);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            LoadFormIntoPanel(dashboard);
        }
    }
}