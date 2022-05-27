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


namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omkar morajkar\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox3.Text)) && (!String.IsNullOrEmpty(textBox4.Text)) && (!String.IsNullOrEmpty(textBox5.Text)))
            {
                if (textBox4.Text == textBox5.Text)
                {
                    if (textBox4.TextLength < 4)
                    {
                        MessageBox.Show("Password Cannot be less than 4 character");
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Insert into Register(Firstname,Lastname,Enumber,Password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
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
                else
                {
                    MessageBox.Show("Password Mismatch");
                }
            }
            else
            {
                MessageBox.Show("Please Fill all the details");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
