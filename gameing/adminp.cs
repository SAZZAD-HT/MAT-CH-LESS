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
    public partial class adminp : Form
    {
        public adminp()
        {
            InitializeComponent();
            disp_data();
        }
        SqlCommand cmd1 = new SqlCommand();
     
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        public void disp_data()
        {

            cmd1.Connection =Database.sqlConnection;

            Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from PLAYER_INFO";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            Database.sqlConnection.Close();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            disp_data();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd1.Connection = Database.sqlConnection;

            Database.sqlConnection.Open();
            Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PLAYER_INFO where PLAYER_NAME = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            Database.sqlConnection.Close();

            disp_data();
            MessageBox.Show("Deletion successful!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PLAYER_INFO where PLAYER_NAME = '" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            Database.sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Notice VALUES ('" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            Database.sqlConnection.Close();
           

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PLAYER_INFO set PLAYER_NAME = '" + textBox3.Text + "' where PLAYER_EMAIL= '" + textBox3.Text + "'";



            cmd.ExecuteNonQuery();
            Database.sqlConnection.Close();
            disp_data();
         
        
    }

        private void button6_Click(object sender, EventArgs e)
        {
            Database.sqlConnection.Open();
            SqlCommand cmdq = Database.sqlConnection.CreateCommand();
            cmdq.CommandType = CommandType.Text;



            cmdq.CommandText = "update PLAYER_INFO set PLAYER_EMAIL = '" + textBox3.Text + "' where PLAYER_EMAIL = '" + textBox3.Text + "'";
            cmdq.ExecuteNonQuery();
            Database.sqlConnection.Close();
            disp_data();
            MessageBox.Show("Updation successful!");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clp form2 = new clp();
            form2.Tag = this;
            form2.Show();
            Hide();
        }
    }
}
