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

namespace gameing
{
    public partial class iqtest2 : Form
    {
        public iqtest2()
        {
            InitializeComponent();
        }
        public iqtest2(String id,string pic)
        {
            InitializeComponent();
            Id = id;
            Pic = pic;

        }
        private string Id;
        private string Pic;


        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        List<String> q2 = new List<string>() { "6" };
        int point;
        private void button1_Click(object sender, EventArgs e)
        {

            if (q2.Contains(textBox1.Text))
            {
                point = 5;
                MessageBox.Show("Right.... you got " + point + " points");
            }
            else
            {
                MessageBox.Show("sorry, you are wrong");
            }

            String query = "INSERT INTO STST_TABLE(iqtest2) VALUES ('" + point + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            level1 form2 = new level1(Id,Pic);
            form2.Tag = this;
            form2.Show();
            Hide();

        }
    }
}
