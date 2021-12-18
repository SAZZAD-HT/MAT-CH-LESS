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
    public partial class level1 : Form
    {
        public level1()
        {
            InitializeComponent();
        }
        public static String Pid;
        public level1(string id, string pic)
        {
            InitializeComponent();
            label1.Text = id;
            label2.Text = pic;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            memorytest form2 = new memorytest(label1.Text, label2.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iqtestp form2 = new iqtestp(label1.Text, label2.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iqtestp form2 = new iqtestp(label1.Text, label2.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gkp form2 = new gkp(label1.Text, label2.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            frmPuzzleGame form2 = new frmPuzzleGame(label1.Text, label2.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            homep form2 = new homep(label1.Text,label2.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void level1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

