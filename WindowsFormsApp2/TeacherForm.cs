using System;
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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchStudent x = new SearchStudent();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherProfile x = new TeacherProfile();
            x.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            label2.Text = Login.nametext1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateGrades x = new updateGrades();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login x = new Login();
            x.Show();
        }
    }
}
