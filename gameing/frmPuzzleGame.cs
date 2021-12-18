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
    public partial class frmPuzzleGame : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        
             
        public frmPuzzleGame()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
           
        }

        public frmPuzzleGame(string id, string pic)
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";

            Id = id;
            Pic = pic;

        }


        private string Id;
        private string Pic;





        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\db\game.mdf;Integrated Security=True;Connect Timeout=30");
        string point = "10";
        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }

        private void frmPuzzleGame_Load(object sender, EventArgs e)
        {

        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Moves Made : 0";
            }

        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {

            if (lblTimeElapsed.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Moves Made : " + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulations...\n YOU GOT 10 POINT \nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves Made : " + inmoves, " Puzzle");
                        inmoves = 0;
                        lblMovesMade.Text = "Moves Made : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }

   

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }
        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", " Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }
        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }
        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves Made : 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up\nTry Again", "Puzzle");
                Shuffle();
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO STST_TABLE(puzzel) VALUES ('" + point + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, Database.sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            level1 from2 = new level1(Id,Pic);
            from2.Tag = this;
            from2.Show();
            Hide();

        }

        private void lblTimeElapsed_Click(object sender, EventArgs e)
        {

        }

        private void gbPuzzleBox_Enter(object sender, EventArgs e)
        {

        }

        private void tmrTimeElapse_Tick(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves Made : 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up\nTry Again", "Puzzle");
                Shuffle();
            }
        }

        private void gbOriginal_Enter(object sender, EventArgs e)
        {

        }
    }
}
