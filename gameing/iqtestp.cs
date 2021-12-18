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
    public partial class iqtestp : Form
    {
        public iqtestp()
        {
            InitializeComponent();
        }
        public iqtestp(String id, string pic)
        {
            InitializeComponent();
            Id = id;
            Pic = pic;
        }

        private string Id;
        private string Pic;

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");

        private void button3_Click(object sender, EventArgs e)
        {
            iqtest2 from2 = new iqtest2(Id,Pic);
            from2.Tag = this;
            from2.Show();
            Hide();
        }



        List<String> q1 = new List<string>() { "1" };
    
        int point;
        private void button1_Click(object sender, EventArgs e)
        {
            if(q1.Contains(textBox1.Text))
            {
                point = 5;
                MessageBox.Show("Right.... you got " + point+" points");
            }
            else
            {
                MessageBox.Show("sorry, you are wrong");
            }

            String query = "INSERT INTO STST_TABLE(iqtest) VALUES ('" + point + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iqtestp_Load(object sender, EventArgs e)
        {

        }
    }
}
