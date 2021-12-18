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
using System.Net;
using System.Net.Mail;


namespace gameing
{

    public partial class createaccount : Form
    {
        String Gender;
      

       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        public createaccount()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }
        public createaccount(String Id)
        {
            InitializeComponent();
            label8.Text = Id;
            picload();
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clp form2 = new clp() ;
            form2.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            avatarp form2 = new avatarp();
            form2.Tag = this;
            form2.Show();
            Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();

                errorProvider1.SetError(this.textBox1, "Player Name cannot empty");
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

                errorProvider1.SetError(this.textBox1, "Player Email cannot empty");
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

                errorProvider1.SetError(this.textBox1, "Password cannot empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();

                errorProvider1.SetError(this.textBox1, "Password should be same");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        String combodata;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combodata = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String picc = label8.Text;
            if (textBox3.Text == textBox4.Text && textBox1.Text != "" && textBox2.Text != "")
            {
                Database.sqlConnection.Open();
            SqlCommand cmd = Database.sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO PLAYER_INFO VALUES ('" +textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','"+Gender+"','"+combodata+"','"+picc+"')";
            cmd.ExecuteNonQuery();
                Database.sqlConnection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

                MessageBox.Show("Insertion successful!");
                String pic = label8.Text;
                congop form2 = new congop(textBox1.Text,pic);
               

                form2.Show();

                Hide();
            }
            
            else
            {
                MessageBox.Show("Password Doesn't Matched");

            }
            //String to, from, pass, mail,msg;

            //msg = textBox1.Text + textBox2.Text + textBox3.Text + radioButton1.Text;
            //to = (textBox2.Text).ToString();
            //from = "20-43045-1@student.aiub.edu";
            //pass = textBox3.Text.ToString();
            //MailMessage message = new MailMessage();
            //message.To.Add(to);
            //message.From = new MailAddress(from);
            //message.Body = msg;
            //message.Subject = "MAT CH LESS";
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);
            //try
            //{
            //    smtp.Send(message);
            //    MessageBox.Show("EMAIL SEND TO YOU", "Email", MessageBoxButtons.OK);
            //}
            //catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}

        
    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female ";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Others";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void txtEmail_Leave(object sender, EventArgs e)

        {

            

        }
        private void textbox_leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (textBox2.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBox2.Text.Trim()))

                {

                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox2.Focus();

                }

            }

        }
    }
}
