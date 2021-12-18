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
    public partial class congop : Form
    {
        public congop()
        {
            
        }
        public congop(String ID,String pic)
        {
            InitializeComponent();
            display1();
            label2.Text = ID;
            label8.Text = pic;
            picload();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        private void display1()
        {

            Database.sqlConnection.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = " select max(PLAYER_ID) FROM PLAYER_INFO ";
            //cmd.ExecuteNonQuery();
            //SqlDataReader reader = com.ExecuteReader();


            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  con.Close();
            //label3.Text = createaccount.name;
            //label4.Text = cmd.CommandText;
            //string str;
            //SqlCommand com;
            //str = " select max(PLAYER_ID) FROM PLAYER_INFO ";
            //com = new SqlCommand(str, con);
            //SqlDataReader reader = com.ExecuteReader();

            //reader.Read();
            //labelname1.Text = reader["bank_name"].ToString();

            string query = "select max(PLAYER_ID) FROM PLAYER_INFO"; //we want to see



            SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);

            //to see output as data table
            DataTable data = new DataTable();
            sda.Fill(data);
            PID = data.Rows[0][0].ToString();
            label4.Text = PID;

            Database.sqlConnection.Close();



        }
        String PID;String picid;

        private void button1_Click(object sender, EventArgs e)
        {
            picid = label8.Text;
            homep form2 = new homep(PID,picid);
            form2.Tag = this;
            form2.Show();
            Hide();
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

        private void congop_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

