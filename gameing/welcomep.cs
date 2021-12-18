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
    public partial class welcomep : Form
    {
        public welcomep()
       {
           InitializeComponent();
            
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clp form2 = new clp();
            form2.Tag = this;
            form2.Show();
            Hide();
        }
    }
}
