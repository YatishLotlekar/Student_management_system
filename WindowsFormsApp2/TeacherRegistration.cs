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
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class TeacherRegistration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Source\Repos\Student_management_system\WindowsFormsApp2\Login.mdf;Integrated Security=True;Connect Timeout=30");
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
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox3.Text)) && (!String.IsNullOrEmpty(textBox4.Text)) && (!String.IsNullOrEmpty(textBox5.Text)) && (!String.IsNullOrEmpty(textBox6.Text)) && (radioButton1.Checked == true ) ||((radioButton2.Checked == true)))
            {
                if (textBox5.Text == textBox6.Text)
                {
                    if (textBox5.TextLength < 4)
                    {
                        MessageBox.Show("Password Cannot be less than 4 character");
                    }
                    else
                    {
                        if (!Regex.IsMatch(textBox2.Text, @"^[a-z A-Z 0-9._%+-]+@[a-z A-Z 0-9.-]+\.[a-z A-Z]{2,4}$"))
                        {
                            MessageBox.Show("Invalid emailID");
                        }
                        else
                        {
                            if (radioButton1.Checked == true)
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand cmd = con.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "Insert into Teacher(Tname,EmailID,Education,Gender,username,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + radioButton1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Data added successfully ");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else if (radioButton2.Checked == true)
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand cmd = con.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "Insert into Teacher(Tname,EmailID,Education,Gender,username,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + radioButton2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Data added successfully ");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password Mismatch");
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
