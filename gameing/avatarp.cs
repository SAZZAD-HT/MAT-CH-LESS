using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameing
{
    public partial class avatarp : Form
    {
        public avatarp()
        {
            InitializeComponent();
        }
         public static String pic;

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void avatarp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic = "1"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic = "2"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pic = "3"; MessageBox.Show("SET SUCCESSFULLY ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pic = "4"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pic = "5"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pic = "6"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            pic = "7"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pic = "8"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pic = "9"; MessageBox.Show("SET SUCCESSFULLY");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pic = "10";
            MessageBox.Show("SET SUCCESSFULLY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createaccount form2 = new createaccount(pic);

            form2.Tag = this;
            form2.Show();
            Hide();
        }
    }
}
