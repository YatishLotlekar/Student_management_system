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
    public partial class ResultForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\omkar morajkar\Documents\Login.mdf;Integrated Security = True; Connect Timeout = 30");
        public ResultForm()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentmenu x = new Studentmenu();
            x.Show();
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            label46.Text = Login.nametext1;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Register where Firstname ='" + Login.nametext1 + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label7.Text = reader["ME"].ToString();
                label8.Text = reader["DAST"].ToString();
                label9.Text = reader["SE"].ToString();
                label33.Text = reader["DC"].ToString();
                label34.Text = reader["CP"].ToString();
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
