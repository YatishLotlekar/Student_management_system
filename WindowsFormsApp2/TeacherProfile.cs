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
    public partial class TeacherProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\Login.mdf;Integrated Security=True;Connect Timeout=30");

        public TeacherProfile()
        {
            
            InitializeComponent();
        }

        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Teacher where Tname ='" + Login.nametext1 + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label8.Text = reader["Firstname"].ToString();

                reader.Read();
                label7.Text = reader["Lastname"].ToString();

                reader.Read();
                //Convert.ToInt32(label9.Text);
                label6.Text = reader["Lastname"].ToString();
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
