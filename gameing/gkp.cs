using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace gameing
{
    public partial class gkp : Form
    {
        public gkp()
        {
            InitializeComponent();
        }
        public gkp(String id, string pic)
        {
            InitializeComponent();
            Id = id;
            Pic = pic;
        }

        private string Id;
        private string Pic;

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        

        private void button2_Click(object sender, EventArgs e)
        {
            level1 form2 = new level1(Id,Pic);
            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void gkp_Load(object sender, EventArgs e)
        {

        }

        List<String> Gk5 = new List<string>(){ "SPAIN", "SUDAN", "SYRIA", "SOMOA" };
        
        List<String> Gk6 = new List<string>() { "SWEDEN", "SERBIA" };
        List<String> Gk7 = new List<string>() { "SOMALIA", "SENEGAL" };
        List<String> Gk8= new List<string>() { "SRILANKA", "SLOVAKIA", "SLOVENIA", "SURINAME", "SCOTLAND" };
        List<String> Gk9= new List<string>() { "SINGAPORE", "SANMARINO" };
        List<String> Gk10= new List<string>()  { "SOUTHKOREA", "SOUTHSUDAN", "SAINTLUCIA", "SEYCHELLES" };
        List<String> Gk11 = new List<string>() { "SOUTHAFRICA", "SAUDIARABIA", "SWITZERLAND", "SIERRALEONE" };
        List<String> Gk14 = new List<string>() { "SOLOMON ISLANDS" };
        string point;
        private void display()
        {
            if (Gk5.Contains(textBox1.Text))
            {
                 point = "5";
                MessageBox.Show("Right.... you got"+point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if(Gk6.Contains(textBox1.Text))
            {
                point = "6";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if (Gk7.Contains(textBox1.Text))
            {
                point = "7";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if (Gk8.Contains(textBox1.Text))
            {
                point = "8";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if (Gk9.Contains(textBox1.Text))
            {
                point = "9";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if (Gk10.Contains(textBox1.Text))
            {
                point = "10";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if (Gk11.Contains(textBox1.Text))
            {
                point = "11";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else if (Gk14.Contains(textBox1.Text))
            {
                point = "14";
                MessageBox.Show("Right.... you got" + point);
                String query = "INSERT INTO STST_TABLE(gktest) VALUES ('" + point + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
