using System;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Game : Form
    {
        bool turn = true;
        bool vscomputer = false;
        int turncount = 0;

        // <--------------------------------------- GAME INICIALIZATE ------------------------------------------->
        public Game()
        {
            InitializeComponent();
        }

        // <--------------------------------------- BUTTONS AND CANVAS ------------------------------------------->

        // Button about information
        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("This game was created by Raicelys A. Suero Payano in February 2021.", "About");
        }
        // Button exit game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
        //Human vs human options button
        private void humanVsHumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.Text = "Player 1";
            p2.Text = "Player2";
            turn = true;
            turncount = 0;
            
                foreach (Control c in Controls)
                {
                   try
                   {
                    Button buttonh = (Button)c;
                    buttonh.Enabled = true;
                    buttonh.Text = "";
                   }
                   catch
                   {
                    // void
                   }
                }
        }
        //Control that the button be enabled or select
        void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button buttonc = (Button)c;
                    buttonc.Enabled = false;
                }
            }
            catch
            {
                // void
            }
        }
        // Character view in the screen for turn
        private void b_enter(object sender, EventArgs e)
        {
            Button buttone = (Button)sender;

            if (buttone.Enabled)
            {
                if (turn)
                    buttone.Text = "X";
                else
                    buttone.Text = "O";
            }
        }
        // Character view in the screen for turn
        private void b_leave(object sender, EventArgs e)
        {
            Button buttonl = (Button)sender;
            if (buttonl.Enabled)
            {
                buttonl.Text = "";
            }
        }
        // Clear board
        private void resertWinBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            owins.Text = "0";
            xwins.Text = "0";
            drawcount.Text = "0";
        }
        //Control computer vs human
        private void p2TextChange(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
                vscomputer = true;
            else
                vscomputer = false;
        }
        // Defaults button computer vs human
        private void setPlayerDefaulfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.Text = "Player";
            p2.Text = "Computer";
            turn = true;
            turncount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button buttonh = (Button)c;
                    buttonh.Enabled = true;
                    buttonh.Text = "";
                }
                catch
                {
                    // void
                }
            }
        }

        // <------------------------------------------------ LOAD ------------------------------------------------->
        private void Form1_Load(object sender, EventArgs e)
        {
            setPlayerDefaulfsToolStripMenuItem.PerformClick();
        }

        // <--------------------------------------- GAME HUMAN VS HUMAN ----------------------------------------->

        //X and O alternate
        void bclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn;
            button.Enabled = false;
            turncount++;
            WinnertheGame(); //Check winner
            
            if ((!turn) && (vscomputer))
            {
                computermove();
            }

        }

        // <--------------------------------------- GAME HUMAN VS COMPUTER ----------------------------------------->
        // Computermove
        private void computermove()
        {
            Button move = null;

            move = lookforwinandb("O"); //look for win
            if (move == null)
            {
                move = lookforwinandb("X"); //look for block
                if (move == null)
                {
                    move = lookforext(); //look the extrem
                    if (move == null)
                    {
                        move = lookopenspace();
                    }
                }
            }
            if(turncount == 9)
                Application.Exit();
            else
            move.PerformClick();
        }
        // Look the open space
        private Button lookopenspace()
        {
            Button button = null;
            foreach (Control c in Controls)
            {
                button = c as Button;
                if (button != null)
                {
                    if (button.Text == "")
                        return button;
                }
            }
            return null;
        }
        // Look the corner or extrem
        private Button lookforext()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }
        // Look for win and block 
        private Button lookforwinandb(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

        // <------------------------------------------ WINNER IDENTIFICATE ----------------------------------------->
        void WinnertheGame()
        {
            bool winner = false;

            //HORIZONTAL
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) //A
                winner = true;
            else if  ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) //B
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) //C
                winner = true;

            // VERTICAL
             else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) // 1
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) // 2
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) // 3 
                winner = true;

            // DIAGONAL
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) // right
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled)) // left
                winner = true;

            if (winner)
            {
                disableButtons();
                string winnerchar = "";
                if (turn)
                {
                    winnerchar = p2.Text;
                    owins.Text = (Int32.Parse(owins.Text) + 1).ToString();
                }
                else
                {
                    winnerchar = p1.Text;
                    xwins.Text = (Int32.Parse(xwins.Text) + 1).ToString();
                }
                MessageBox.Show(winnerchar + " is the winner! ");
            }
            else
            {
                if (turncount == 9)
                { 
                    drawcount.Text = (Int32.Parse(drawcount.Text) + 1).ToString();
                    MessageBox.Show("NO WINNER!, PLAY AGAIN!", "Tic tac toe");
                 }
            }
        }

        // <----------------------------------------- VOID THINGS -------------------------------------------------->
        private void label1_Click(object sender, EventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void label3_Click(object sender, EventArgs e)
        { }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        private void pictureBox1_Click(object sender, EventArgs e)
        { }
        private void label1_Click_1(object sender, EventArgs e)
        { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {  }

    }
}

