﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TeacherRegistration : Form
    {
        public TeacherRegistration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox3.Text)) && (!String.IsNullOrEmpty(textBox4.Text)) && (!String.IsNullOrEmpty(textBox5.Text)) && (!String.IsNullOrEmpty(textBox6.Text)))
            {
                if (textBox5.Text == textBox6.Text)
                {

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Fill all the details");
            }
        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
