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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\omkar morajkar\Documents\Login.mdf;Integrated Security = True; Connect Timeout = 30");
        public static string nametext1 = "";
        public Login()
        {
            InitializeComponent();
        }
        int fno;

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
                        cmd.ExecuteNonQuery();
                        fno = 1;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        cmd.CommandText = "Select username,password from Teacher where username ='" + textBox1.Text + "'and password ='" + textBox2.Text + "'";
                        cmd.ExecuteNonQuery();
                        fno = 2;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        cmd.CommandText = "Select Firstname,Password from Register where Firstname ='" + textBox1.Text + "'and Password ='" + textBox2.Text + "'";
                        cmd.ExecuteNonQuery();
                        fno = 3;
                    }
                    else
                    {
                        MessageBox.Show("Select user");
                    }
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    nametext1 = textBox1.Text;
                    if (dt.Rows.Count > 0)
                    {
                        if (fno == 1)
                        {
                            this.Hide();
                            AdminForm x = new AdminForm();
                            x.Show();
                        }
                        else if (fno == 2)
                        {
                            this.Hide();
                            TeacherForm x = new TeacherForm();
                            x.Show();
                        }
                        else if (fno == 3)
                        {
                            this.Hide();
                            Studentmenu x = new Studentmenu();
                            x.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
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
            this.Hide();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
