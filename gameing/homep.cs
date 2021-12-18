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
    public partial class homep : Form
    {
        public homep()
        {
            InitializeComponent();
        }
        public homep(String ID,String pic)
        {
            InitializeComponent();
            label2.Text = ID;
            label8.Text = pic;
            picload();

        }


        private void button2_Click(object sender, EventArgs e)
        {

            tictactoep form8 = new tictactoep();
            form8.Tag = this;
            form8.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clp form2 = new clp();
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rankingp form2 = new rankingp(label2.Text, label8.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            noticep form2 = new noticep(label2.Text, label8.Text);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level1 form2 = new level1(label2.Text,label8.Text);
            //form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void homep_Load(object sender, EventArgs e)
        {

        }
        public void picload()
        {
            if (label8.Text == "pic")
            {
                label8.Text = "SET PIC";
            }
            else if (label8.Text == "1")
            {
                pictureBox1.Image = Properties.Resources.boy1;

            }
            else if (label8.Text == "2")
            {
                pictureBox1.Image = Properties.Resources.girl1;
            }
            else if (label8.Text == "3")
            {
                pictureBox1.Image = Properties.Resources.boy2;
            }
            else if (label8.Text == "4")
            {
                pictureBox1.Image = Properties.Resources.girl2;
            }
            else if (label8.Text == "5")
            {
                pictureBox1.Image = Properties.Resources.boy3;
            }
            else if (label8.Text == "6")
            {
                pictureBox1.Image = Properties.Resources.girl5;
            }
            else if (label8.Text == "7")
            {
                pictureBox1.Image = Properties.Resources.boy5;
            }
            else if (label8.Text == "8")
            {
                pictureBox1.Image = Properties.Resources.girl4;
            }
            else if (label8.Text == "9")
            {
                pictureBox1.Image = Properties.Resources.boy4;
            }
            else if (label8.Text == "10")
            {
                pictureBox1.Image = Properties.Resources.girl3;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           localp form2 = new localp(label2.Text,label8.Text);

            //form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ststp form2 = new ststp();
            form2.Tag = this;
            form2.Show();
            Hide();
        }
    }
}
