﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string Replay = ClientsData.OpenStreams();
            if (Replay != "Opened")
            {
                MessageBox.Show(Replay, "Can't Open Data File",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            Replay = ClientsLogs.OpenStreams();
            if (Replay != "Opened")
            {
                MessageBox.Show(Replay, "Can't Open Data File",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmLog.Text = "nguyenhieu@gmail.com";
            PassLog.Text = "12345";
            PassLog.PasswordChar = '*';
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Registration()).ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show
           ("Any questions please contact us on email accounts :\nHieuntgcd17166@fpt.edu.vn\nHot Line: 0xxxxxxxx",
             "About Us");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit?!", "Exit",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (!ClientsData.CloseStreams() || !ClientsLogs.CloseStreams())
                {
                    MessageBox.Show("Data File Can't Be Closed Correctly!", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmLog.Text.Length < 1 || PassLog.Text.Length < 1)
            {
                MessageBox.Show("Please Enter Your Email & Password And Try Again!", "Error");
            }
            else
            {
                if (ClientsData.LogInChecker(EmLog.Text.ToLower(), PassLog.Text))
                {
                    this.Hide();
                    (new MyAccount()).ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Please Correct Your Email & Password And Try Again!", "Error");
                }

            }
        }
    }
}
