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
    
    public partial class noticep : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        public noticep()
        {
            InitializeComponent();
            Display();
        }

        public noticep(string id, string pic)
        {
            InitializeComponent();
            Display();
            Id = id;
            Pic = pic;
        }

        private string Id;
        private string Pic;


        private void button2_Click(object sender, EventArgs e)
        {
            homep form2 = new homep(Id,Pic);
            form2.Tag = this;
            form2.Show();
            Hide();
        }
        //private void Display()
        //{
        //    string query = "select  notice FROM notice"; //we want to see



        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);

        //    //to see output as data table
        //    DataTable data = new DataTable();
        //    sda.Fill(data);
        //   String Notice = data.Rows[0][0].ToString();
        //    label3.Text = Notice;



        //}

        public string display()
        {

           // SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "select notice from notice where num=(select Max(num) from notice)";
           
            cmd.CommandType = CommandType.Text;
           
            cmd.Connection =Database.sqlConnection;
            

           Database.sqlConnection.Open();

            returnValue = cmd.ExecuteScalar();

            Database.sqlConnection.Close();

            return returnValue.ToString();
        }
         
        public void Display()
        {
            label3.Text = display();
        }

            private void noticep_Load(object sender, EventArgs e)
        {

        }
    }
}
