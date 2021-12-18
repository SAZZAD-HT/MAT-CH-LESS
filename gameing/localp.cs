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
    public partial class localp : Form
    {
        public localp()
        {
            InitializeComponent();
        }

        public localp(String id, string pic)
        {
            InitializeComponent();
            label1.Text = id;
            label2.Text = pic;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            homep form2 = new homep(label1.Text,label2.Text);

            //form2.Tag = this;
            form2.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tictactoep form2 = new tictactoep(label1.Text, label2.Text);

            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void localp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
