using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TRUEconnect4_final
{
    public partial class gameForm : Form
    {
        int[,] angryChipLocationArray = new int[7, 6];  //Array for chip locations
        int turn;// global variable for turn
        bool gameover = true;
        int row, col; // row and col of peg that is being dropped in
        int TempRow; // temporary row for animation
        bool AnimationHappen; // bool to check if animation is happening


        // Win numbers for scoreboard
        int yellowWins = 0; 
        int redWins = 0;

        public gameForm()
        {
            InitializeComponent();
            //Background of pbGame
            pbGame.Image = Image.FromFile("elmo.gif");
            //Initialize scoreboard
            txtYWin.Text = "0";
            txtRWin.Text = "0";
        }

        public void InitializeGame()
        {
            //initializing all array spaces to empty (0 = empty, 1 = occupied by yellow chip, 2 = occupied by red chip)
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    angryChipLocationArray[i, j] = 0;
                }
            }

            turn = 1; // Yellow starts
            gameover = false; //Game is not over
        }


        //initializing board
        private void pbGame_Paint(object sender, PaintEventArgs e)
        {
            // Initialize graphics, x, y, i, j;
            Graphics g = e.Graphics;
            float x = 0, y = 0;
            int i, j;

            // Initialize pen
            Pen borderPen = new Pen(Color.AntiqueWhite, 3);

            //Veritcal lines
            for (i = 0; i < 8; i++)
            {
                g.DrawLine(borderPen, x, 0, x, 600);
                x = x + 100;
            }
            //Horizontal lines
            for (j = 0; j < 7; j++)
            {
                g.DrawLine(borderPen, 0, y, 703, y);
                y = y + 100;
            }

            //placing pegs
            for (int p = 0; p < 7; p++)
            {
                for (int q = 0; q < 6; q++)
                {
                    if (angryChipLocationArray[p, q] ==1) //if yellow, place appropriate peg
                    {
                       

                        g.DrawImage(Image.FromFile("Angry-Yellow-Peg.png"),p * 100, q * 100, 100, 100);
                    }
                    else if (angryChipLocationArray[p, q] == 2) //if red, place appropriate peg
                    {
                        g.DrawImage(Image.FromFile("Angry-Red-Peg.png"), p * 100, q * 100, 100, 100);
                    }
                }
            }
           
        }
        public int findRow(int col)
        {
            int row;
            // Checks if row is empty and returns the row # if it is
            for (int i = 5; i >= 0; i--)
            {
                if (angryChipLocationArray[col, i] == 0)
                {
                    row = i;
                    return row;
                }
            }
            return -1; // returns -1 if all are full
        }

        public bool HorizontalWin(int col, int row)
        {
            bool win = false; //to check if win
            // scenario for xooo win
            if (col<=3)
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row] &&  angryChipLocationArray[col + 2, row] == angryChipLocationArray[col, row] && angryChipLocationArray[col + 3, row] == angryChipLocationArray[col, row]) //xooo
                {
                    win =true;
                }
               
            }
            // scenario for ooxo win
            if (col >= 2 && col <= 5)
            {

                if (angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 2, row] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row]) //ooxo
                {
                    win = true;
                }
            }
            // scenario for oxoo win
            if (col>0 && col < 5)
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 2, row] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row]) //oxoo
                {
                    win = true;
                }
            }
            // scenario for ooox win
            if (col > 2)
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 2, row] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 3, row]) //ooox
                {
                    win = true;
                }
            }
            return win;
        }

        public bool VerticalWin(int col, int row)
        {
            bool win = false; //bool for win
            if (row < 3) // scenario for vertical win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col, row + 1] && angryChipLocationArray[col, row + 2] == angryChipLocationArray[col, row] && angryChipLocationArray[col, row + 3] == angryChipLocationArray[col, row]) //xooo
                {
                    win = true;
                }

            }
            return win;
        }

        public bool DiagonalWin(int col, int row)
        {
            bool win = false;

            //diagonal going up
            if (col < 4 && row > 2) //scenario for xooo win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row - 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 2, row - 2] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 3, row - 3]) //xooo
                {
                    win = true;
                }
               
            }
            if (col < 5 && col > 0 && row < 5 && row > 1) //scenario for oxoo win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col -1, row + 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row - 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 2, row - 2])//oxoo
                {
                    win = true;
                }
            }
            if (col > 1 && col < 6 && row > 0 && row < 4) //scenario for ooxo win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col - 2, row + 2] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row + 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row - 1])//ooxo
                {
                    win = true;
                }
            }
            if (col > 2 && row < 3) //scenario for ooox win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col - 3, row + 3] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 2, row + 2] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row + 1])//ooox
                {
                    win = true;
                }
            }

            //diagonal going down
            if (col < 4 && row < 3) //scenario for xooo win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row + 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 2, row + 2] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 3, row + 3]) //xooo
                {
                    win = true;
                }
            }
            if (col > 0 && col < 5 && row > 0 && row < 4) //scenario for oxoo win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row - 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row + 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 2, row + 2]) //oxoo
                {
                    win = true;
                }
            }
            if (col > 1 && col < 6 && row > 1 && row < 5) //scenario for ooxo win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col - 2, row - 2] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row - 1] && angryChipLocationArray[col, row] == angryChipLocationArray[col + 1, row + 1])//ooxo
                {
                    win = true;
                }
            }
            if (col > 2 && row > 2) //scenario for ooox win
            {
                if (angryChipLocationArray[col, row] == angryChipLocationArray[col - 3, row - 3] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 2, row - 2] && angryChipLocationArray[col, row] == angryChipLocationArray[col - 1, row - 1])//ooox
                {
                    win = true;
                }
            }
            return win;

        }

        private void pbGame_MouseClick(object sender, MouseEventArgs e)
        {
            try {

                // Doesn't let click if animation happening
                if (AnimationHappen == true)
                {
                    return;
                }

                // Message if gameover
                if(gameover==true)
                {
                    //error and return
                    MessageBox.Show("Please start a new game :)");
                    return;
                }
                int mouseX = e.X;

                // Checks which column mouse has clicked
                col = -1;
                for (int i = 0; i < 7; i++)
                {
                    if (mouseX > i * 100 && mouseX < (i + 1) * 100)
                    {
                        col = i;
                        break;
                    }
                }

                //Finds empty row of column
                row = findRow(col);

                //Message if column full
                if (row == -1)
                {
                    MessageBox.Show("This column is full!");
                }
                //Else, start timer for animation
                else
                {
                    AnimationHappen = true;
                    TempRow = 0;
                    Connect4Timer.Start();
                }
            }
            catch
            {
                //Error message
                MessageBox.Show("ERROR");
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Starts new game
            try
            {
                InitializeGame();
                pbGame.Invalidate();
                txtTurn.Text = "Yellows Turn";
            }
            catch
            {
                //Error message
                MessageBox.Show("ERROR");
            }
        }
       
        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                //Quits application
                MessageBox.Show("Thanks for playing!");
                System.Windows.Forms.Application.ExitThread();
            }
            catch
            {
                //Error message
                MessageBox.Show("ERROR");
            }
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            try
            {
                // Resets score and output it
                yellowWins = 0;
                redWins = 0;
                txtYWin.Text = yellowWins.ToString();
                txtRWin.Text = redWins.ToString();
            }
            catch
            {
                //Error message
                MessageBox.Show("ERROR");
            }
        }

        private void Connect4Timer_Tick(object sender, EventArgs e)
        {

            if (TempRow==row)
            {
                //stops timer
                Connect4Timer.Stop();
                //Removes peg before the real peg if row not 0
                if(row != 0)
                {
                    angryChipLocationArray[col, row - 1] = 0;
                }
                // Puts peg into (col, row) of the chip array
                angryChipLocationArray[col, row] = turn;
                pbGame.Invalidate();

                //win condition + changing turns
                bool winH = HorizontalWin(col, row);
                bool winV = VerticalWin(col, row);
                bool winD = DiagonalWin(col, row);

                // Animation false
                AnimationHappen = false;

                if (turn == 1) // yellow has turn
                {
                    if (winH == true || winV == true || winD == true) // Checks if any win-condition is true
                    {
                        //Outputs message, adds to score, updates score, makes game over, and returns.
                        MessageBox.Show("Yellow Wins!!");
                        yellowWins++;
                        txtYWin.Text = yellowWins.ToString();
                        txtRWin.Text = redWins.ToString();
                        gameover = true;
                        return;
                    }
                    turn = 2;  // give turn to Red
                    txtTurn.Text = "Red's Turn";
                }
                else // Red has a turn
                {
                    if (winH == true || winV == true || winD == true) // Checks if any win-condition is true
                    {
                        //Outputs message, adds to score, updates score, makes game over, and returns.
                        MessageBox.Show("Red  Wins!!");
                        redWins++;
                        txtYWin.Text = yellowWins.ToString();
                        txtRWin.Text = redWins.ToString();
                        gameover = true;
                        return;
                    }
                    turn = 1;  // give turn to yellow
                    txtTurn.Text = "Yellow's Turn";
                }
               
            }
            //else creates temp peg
            else
            {
                if (TempRow != 0)
                {
                    //Empties row before temprow if temprow isn't 0
                    angryChipLocationArray[col, TempRow - 1] = 0;
                }
                // Adds peg to chip array of col, temprow
                angryChipLocationArray[col, TempRow] = turn;
                //Add 1 to temprow
                TempRow = TempRow + 1;
                pbGame.Invalidate();
            }
        }
    }
}
