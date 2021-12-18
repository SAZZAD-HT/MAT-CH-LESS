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
    public partial class memorytest : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "p", "p", "N", "N","Z", "Z",
            ",", ",", "l", "l", "b", "b", "G", "G"
        };
        String user;
        Label firstClicked, secondClicked; 
        public memorytest()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        public memorytest(string id, string pic)
        {
            InitializeComponent();
            AssignIconsToSquares();
            Id = id;
            Pic = pic;
        }

        private string Id;
        private string Pic;




      //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        

        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return;
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            WinnerCheckenDinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();
        }
        private void WinnerCheckenDinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            MessageBox.Show("Congratulations! You Matched All Symbols..\n You get 5 point ");
            string point="5";

            Database.sqlConnection.Open();

            String query = "INSERT INTO STST_TABLE(memorytest) VALUES ('"+point+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            level1 form2 = new level1(Id,Pic);
            form2.Tag = this;
            form2.Show();
            Hide();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;

        }
        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];

                icons.RemoveAt(randomNumber);
            }
        }
    }
}
