using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class f_AddOrRemoveForm : Form
    {
        public f_AddOrRemoveForm()
        {
            InitializeComponent();
        }

        private void f_AddOrRemoveForm_Load(object sender, EventArgs e)
        {

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



        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timer1.Enabled == false && maskedTextBox1.Text.Length == 0)
            {
                maskedTextBox1.Clear();
                timer1.Start();


            }





            // timer1.Enabled = false;
        }
    }

}

}
