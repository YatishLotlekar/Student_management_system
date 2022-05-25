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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omkar morajkar\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    if (radioButton1.Checked == true)
                    {
                        cmd.CommandText = "Select username,password from Admin where username ='" + textBox1.Text + "'and password ='" + textBox2.Text + "'";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        cmd.CommandText = "Select username,password from Teacher where username ='" + textBox1.Text + "'and password ='" + textBox2.Text + "'";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        cmd.CommandText = "Select Enumber,Password from Register where Enumber ='" + textBox1.Text + "'and Password ='" + textBox2.Text + "'";
                    }
                    else
                    {
                        MessageBox.Show("Select user");
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Form3 x = new Form3();
                        x.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Username or Password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm x = new RegisterForm();
            x.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Your Administrator");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
