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
    public partial class updateGrades : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\omkar morajkar\Documents\Login.mdf;Integrated Security = True; Connect Timeout = 30");
        public updateGrades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm x = new TeacherForm();
            x.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox3.Text)) && (!String.IsNullOrEmpty(textBox4.Text)) && (!String.IsNullOrEmpty(textBox5.Text)) && (!String.IsNullOrEmpty(textBox2.Text)))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Register SET ME = '"+textBox1.Text+ "', DAST = '" + textBox2.Text + "', SE = '" + textBox3.Text + "', DC = '" + textBox4.Text + "', CP = '" + textBox5.Text + "' Where Enumber='" + textBox6.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data added successfully ");
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
    }
}
