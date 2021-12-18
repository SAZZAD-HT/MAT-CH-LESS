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
    public partial class clp : Form
    {
        public clp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createaccount button2 = new createaccount();
            button2.Tag = this;
            button2.Show();
            Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginp button1 = new loginp();
            button1.Tag = this;
            button1.Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            homep button1 = new homep();
            button1.Tag = this;
            button1.Show();
            Hide();
        }

        private void clp_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adminlg n = new Adminlg();
            n.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
