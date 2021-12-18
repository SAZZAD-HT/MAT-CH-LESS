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
using System.Text.RegularExpressions;



namespace gameing
{
    public partial class loginp : Form
    {
        //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        public loginp()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }
        private static String ID;

        private void button2_Click(object sender, EventArgs e)
        {
           clp form2 = new clp();

            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string query = "select *from PLAYER_INFO where PLAYER_NAME='" + textBox2.Text.Trim() + "'and PLAYER_PASS ='" + textBox3.Text.Trim() + "'and  PLAYER_ID ='"+ textBox1.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                loginp INFO = new loginp();
                this.Hide();
                INFO.Show();
                ID = textBox1.Text;
                display();
                PIC = display();
                homep form2 = new homep(ID,PIC);
                
                form2.Tag = this;
                form2.Show();
                Hide();
               
              



            }
            else
            {
                MessageBox.Show("NOT FOUND");
                //Hide();
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)==true)
            {
                textBox1.Focus();

                errorProvider1.SetError(this.textBox1, "Player Id cannot empty");
            }
            else 
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();

                errorProvider1.SetError(this.textBox1, "Player Name cannot empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();

                errorProvider1.SetError(this.textBox1, "Passward cannot empty");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void loginp_Load(object sender, EventArgs e)
        {

        }
        string PIC;

        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=.;Initial Catalog=UserEmp;Integrated Security=True";
        private SqlCommand sqlCommand;
        public string display()
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "select PLAYER_PIC FROM PLAYER_INFO where PLAYER_ID=('"+textBox1.Text+"') "; 
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            returnValue = cmd.ExecuteScalar();

            sqlConnection.Close();

            return returnValue.ToString();



            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["CN"].ConnectionString;
            //string query = "select * from Product";
            //SqlDataAdapter adp = new SqlDataAdapter(query, con);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    lblClient.Enabled = true;
            //    lblClient1.Enabled = true;
            //    lblClient2.Enabled = true;
            //    lblClient3.Enabled = true;
            //    lblClient.Text = ds.Tables[0].Rows[0].Field("P_Name");
            //    lblClient1.Text = ds.Tables[0].Rows[1].Field("P_Name");
            //    lblClient2.Text = ds.Tables[0].Rows[2].Field("P_Name");
            //    lblClient3.Text = ds.Tables[0].Rows[3].Field("P_Name");
            //}
            // int b = Int32.Parse(textBox1.Text);
            //string query = $"Select PLAYER_PIC from PLAYER_INFO where PLAYER_ID = {textBox1.Text}";
            //this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            //SqlDataReader data = sqlCommand.ExecuteReader();

            //return data;

            //sql.Open();
            //string query = "select PLAYER_PIC FROM PLAYER_INFO where PLAYER_ID=1013 "; //we want to see



            //SqlDataAdapter sda = new SqlDataAdapter(query, sql);

            ////to see output as data table
            //DataTable data = new DataTable();
            //sda.Fill(data);
            // PIC = data.Rows[0][0].ToString();
            //sql.Close();
        }
    }
    }

