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
    public partial class Studentmenu : Form
    {
        public Studentmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile x = new Profile();
            x.Show();
        }

        private void Studentmenu_Load(object sender, EventArgs e)
        {
            //Login.nametext1 = label2.Text;
            label2.Text = Login.nametext1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login x = new Login();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultForm x = new ResultForm();
            x.Show();
        }
    }
}
