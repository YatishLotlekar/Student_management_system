﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class SearchStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\omkar morajkar\Documents\Login.mdf;Integrated Security = True; Connect Timeout = 30");
        public SearchStudent()
        {
            InitializeComponent();
        }
        public void display()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Register where username ='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from Register where Firstname ='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            //display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm x = new TeacherForm();
            x.Show();
        }
    }
}
