using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameing
{
    public partial class tictactoep : Form
    {
        enum PlayerTurn { None, Player1, Player2 };
        enum Winner { None, Player1, Player2, Draw };
        PlayerTurn turn;
        Winner winner;
        void OnNewGame()
        {
            PictureBox[] allPictures = { pictureBox0,
                                          pictureBox1,
                                          pictureBox2,
                                          pictureBox3,
                                          pictureBox4,
                                          pictureBox5,
                                          pictureBox6,
                                          pictureBox7,
                                          pictureBox8,
                                          };

            //Clear all game board cells
            foreach (var p in allPictures)
            {
                p.Image = null;
            }

            turn = PlayerTurn.Player1;
            winner = Winner.None;
            ShowTurn();
        }
        Winner GetWinner()
        {
            PictureBox[] allWinningMoves = {
                                             //Check each row
                                             pictureBox0, pictureBox1, pictureBox2,
                                             pictureBox3, pictureBox4, pictureBox5,
                                             pictureBox6, pictureBox7, pictureBox8,
                                             //Columns
                                             pictureBox0, pictureBox3, pictureBox6,
                                             pictureBox1, pictureBox4, pictureBox7,
                                             pictureBox2, pictureBox5, pictureBox8,
                                             //Diagonal
                                             pictureBox0, pictureBox4, pictureBox8,
                                             pictureBox2, pictureBox4, pictureBox6
                                          };

            for (int i = 0; i < allWinningMoves.Length; i += 3)
            {
                if (allWinningMoves[i].Image != null)
                {
                    if (allWinningMoves[i].Image == allWinningMoves[i + 1].Image &&
                        allWinningMoves[i].Image == allWinningMoves[i + 2].Image)
                    {
                        if (allWinningMoves[i].Image == player1.Image)
                        {
                            return Winner.Player1;
                        }
                        else
                        {
                            return Winner.Player2;
                        }

                    }
                }
            }

            //Check for empty cell
            PictureBox[] allPictures = { pictureBox0,
                                          pictureBox1,
                                          pictureBox2,
                                          pictureBox3,
                                          pictureBox4,
                                          pictureBox5,
                                          pictureBox6,
                                          pictureBox7,
                                          pictureBox8,
                                          };

            //Clear all game board cells
            foreach (var p in allPictures)
            {
                if (p.Image == null)
                {
                    return Winner.None;
                };
            }

            //it is definitely a draw
            return Winner.Draw;
        }
        void ShowTurn()
        {
            string status = "";
            string msg = "";

            switch (winner)
            {
                case Winner.None:
                    if (turn == PlayerTurn.Player1)
                        status = "Turn: Player 1";
                    else
                        status = "Turn: Player 2";
                    break;
                case Winner.Player1:
                    msg = status = "Player 1 Wins!";

                    break;
                case Winner.Player2:
                    msg = status = "Player 2 Wins";
                    break;
                case Winner.Draw:
                    status = "Looks like its a draw!";
                    break;
            }

            lblstatus.Text = status;
            if (msg != "")
            {
                MessageBox.Show(msg, "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public tictactoep()
        {
            InitializeComponent();
        }

        public tictactoep(string id, string pic)
        {
            InitializeComponent();
            Id = id;
            Pic = pic;
            
        }
        private string Id;
        private string Pic;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (p.Image != null)
                return;
            if (turn == PlayerTurn.None)
                return;

            if (turn == PlayerTurn.Player1)
            {
                p.Image = player1.Image;
            }
            else
            {
                p.Image = player2.Image;
            }

            //Check for a winner
            winner = GetWinner();
            if (winner == Winner.None)
            {
                //Change turns
                turn = (PlayerTurn.Player1 == turn) ? PlayerTurn.Player2 : PlayerTurn.Player1;
            }
            else
            {
                turn = PlayerTurn.None;
            }


            ShowTurn();

        }

        private void btnNewButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game?",
                                          "New Game",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OnNewGame();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             localp form2 = new localp(Id,Pic);

            form2.Tag = this;
            form2.Show();
            Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            OnNewGame();
        }

        private void player1_Click(object sender, EventArgs e)
        {

        }
    }
}
