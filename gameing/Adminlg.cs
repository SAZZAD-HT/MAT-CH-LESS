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
    public partial class Adminlg : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        public Adminlg()
        {
            InitializeComponent();
            textBox3.PasswordChar = '$';        }

        private void Adminlg_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            clp form2 = new clp();
            form2.Tag = this;
            form2.Show();
            Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Database.sqlConnection;
            string query = "select *from admin where Admin_NAME='" + textBox2.Text.Trim() + "'and admin_id ='" + textBox3.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                loginp INFO = new loginp();
                this.Hide();
                INFO.Show();

                adminp form2 = new adminp();
                form2.Tag = this;
                form2.Show();
                Hide();




            }
            else
            {
                MessageBox.Show("NOT FOUND");
               
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
