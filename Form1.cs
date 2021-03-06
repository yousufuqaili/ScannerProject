﻿using System;
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
            KeyPreview = true;
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

            if (maskedTextBox1.Text.Length > 12)
            {


                string barcode = maskedTextBox1.Text;

            }
            else
            {
                maskedTextBox1.Clear();
                timer1.Stop();

            }
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