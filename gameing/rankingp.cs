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
    public partial class rankingp : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        public rankingp()
        {
            InitializeComponent();
            disp_data();
        }
        public rankingp(string id, string pic)
        {
            InitializeComponent();
            Id = id;
            Pic = pic;
            disp_data();
        }

        private string Id;
        private string Pic;

        private void button2_Click(object sender, EventArgs e)
        {
            homep form2 = new homep(Id, Pic);
            form2.Tag = this;
            form2.Show();
            Hide();
        }
        public void disp_data()
        {

            //ataTable tableone = ds.Tables[0];

            //tableone.Select().ToList().ForEach(row =>
            //{

            //    string FirstName = Convert.ToString(row["FName"], CultureInfo.InvariantCulture);
            //    string LastName = Convert.ToString(row["LName"], CultureInfo.InvariantCulture);
            //    double xxx = Convert.ToDouble(row["WaitTime"]);

            //    row.SetField("WaitTime", secondsToTime(xxx));
            //    row.SetField("FullName", string.Format("{0} {1}", FirstName, LastName));
            //});

            //private string secondsToTime(double seconds)
            //{
            //    TimeSpan t = TimeSpan.FromSeconds(seconds);
            //    string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
            //        t.Hours,
            //        t.Minutes,
            //        t.Seconds);
            //    return answer;
            //}

            Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from STST_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            Database.sqlConnection.Close();
            //DataSet customerOrders = new DataSet("CustomerOrders");

            //DataTable table = customerOrders.Tables.Add("Orders");

            //// table = new DataTable();
            //DataRow dr = table.NewRow();
            //table.Columns.Add("id", typeof(int));
            //table.Columns.Add("Name", typeof(string));
            //table.Rows.Add(1, "Indocin");
            //table.Rows.Add(2, "Enebrel");
            //table.Rows.Add(3, "Hydralazine");
            //table.Rows.Add(4, "Combivent");
            //table.Rows.Add(5, "Dilantin");
            //dr = customerOrders.Tables[0].Rows[0];
            //Label1.Text = dr[0].ToString();

        }
        private void rankingp_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
