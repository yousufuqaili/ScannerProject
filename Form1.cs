using System;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class Form1 : Form
    {
        private const string dev = "rohit_rtk@hotmail.com";
        private const string pass = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            l_Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void b_SubmitInfo_Click(object sender, EventArgs e)
        {
            var login = textBox_TeacherLogin.Text;
            var password = textBox_TeacherPassword.Text;

            if (!(login.Equals(dev) && password.Equals(pass)))
            {
                MessageBox.Show("You have entered incorrect login information!\nPlease try again!", "Invalid Information!");
                return;
            }

            textBox_TeacherLogin.Clear();
            textBox_TeacherPassword.Clear();
        }
    }
}