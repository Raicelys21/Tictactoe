using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TictactoeS_C
{
    public partial class MP : Form
    {
        //Players
        private char Player1; 
        private char Player2;

        //Socket
        private Socket socket;
        private BackgroundWorker ContentReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        //  <--------------------------------------- INICIALIZATE --------------------------------------->
        public MP(bool Server, string addressip = null)
        {
            InitializeComponent();
            ContentReceiver.DoWork += ContentReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (Server)
            {
                Player1 = 'X';
                Player2 = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 9060);
                server.Start();
                socket = server.AcceptSocket();
            }
            else
            {
                Player1 = 'O';
                Player2 = 'X';

                try
                {
                    client = new TcpClient(addressip, 9060);
                    socket = client.Client;
                    ContentReceiver.RunWorkerAsync();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    Close();
                }

            }
        }

        //  <--------------------------------------- SOCKETS --------------------------------------------->
        private void ContentReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CheckWinner())
                return;

            BlockScreen();
            label1.Text = "Espere por su turno!";

            ReceivedContent();
            label1.Text = "Es tu turno de jugar!";

            if (!CheckWinner())
                UnblockScreen();
        }

        //  <--------------------------------------- FUNCTIONS ----------------------------------------->
        //Check the winner
        private bool CheckWinner()
        {
            //HORIZONTAL
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A3.Text != ""))
            {
                if (A1.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B3.Text != ""))
            {
                if (B1.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C3.Text != ""))
            {
                if (C1.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            //VERTICAL

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (C1.Text != ""))
            {
                if (A1.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (C2.Text != ""))
            {
                if (A2.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (C3.Text != ""))
            {
                if (A3.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            //DIAGONAL

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (C3.Text != ""))
            {
                if (A1.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (C1.Text != ""))
            {
                if (A3.Text[0] == Player1)
                {
                    label1.Text = "Ganaste!";
                }
                else
                {
                    label1.Text = "Perdiste!";
                }
                return true;
            }

            //DRAW
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != "" && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                label1.Text = "Empate!";
                return true;
            }

            return false;
        }
        //Block the screen
        private void BlockScreen()
        {
            //A
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            //B
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            //C
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }
        // Unblock the screen
        private void UnblockScreen()
        {
            //A
            if (A1.Text == "")
                A1.Enabled = true;
            if (A2.Text == "")
                A2.Enabled = true;
            if (A3.Text == "")
                A3.Enabled = true;

            //B
            if (B1.Text == "")
                B1.Enabled = true;
            if (B2.Text == "")
                B2.Enabled = true;
            if (B3.Text == "")
                B3.Enabled = true;

            //C
            if (C1.Text == "")
                C1.Enabled = true;
            if (C2.Text == "")
                C2.Enabled = true;
            if (C3.Text == "")
                C3.Enabled = true;
        }
        //Move with socket passed received content
        private void ReceivedContent()
        {
            //A
            byte[] content = new byte[1];
            socket.Receive(content);
            if (content[0] == 1)
                A1.Text = Player2.ToString();
            if (content[0] == 2)
                A2.Text = Player2.ToString();
            if (content[0] == 3)
                A3.Text = Player2.ToString();
            //B
            if (content[0] == 4)
                B1.Text = Player2.ToString();
            if (content[0] == 5)
                B2.Text = Player2.ToString();
            if (content[0] == 6)
                B3.Text = Player2.ToString();
            //C
            if (content[0] == 7)
                C1.Text = Player2.ToString();
            if (content[0] == 8)
                C2.Text = Player2.ToString();
            if (content[0] == 9)
                C3.Text = Player2.ToString();

        }

        // <--------------------------------------- VOID THING  --------------------------------------->
        private void label1_Click(object sender, EventArgs e)
        {    }
        private void MP_Load(object sender, EventArgs e)
        {     }

        //  <--------------------------------------- BUTTON CLICK  --------------------------------------->

        //A
        private void b1click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            socket.Send(num);
            A1.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        private void b2click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            socket.Send(num);
            A2.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        private void b3click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            socket.Send(num);
            A3.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        //B
        private void b4click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            socket.Send(num);
            B1.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        private void b5click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            socket.Send(num);
            B2.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        private void b6click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            socket.Send(num);
            B3.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        //C
        private void b7click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            socket.Send(num);
            C1.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        private void b8click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            socket.Send(num);
            C2.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();
        }

        private void b9click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            socket.Send(num);
            C3.Text = Player1.ToString();
            ContentReceiver.RunWorkerAsync();

        }


        // <--------------------------------------- CLOSED THE GAME  --------------------------------------->
        private void MP_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContentReceiver.WorkerSupportsCancellation = true;
            ContentReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }
    }
}
