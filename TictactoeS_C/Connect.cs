using System;
using System.Windows.Forms;

namespace TictactoeS_C
{
    public partial class Connect : Form
    {
        // <---------------------------------------  INICIALIZATE AND LOAD ------------------------------------>
        public Connect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // <---------------------------------------   BUTTONS ------------------------------------>
        private void bConnect_Click(object sender, EventArgs e)
        {
            MP Startgame = new MP(false, textBox1.Text);
            Visible = false;
            if (!Startgame.IsDisposed)
                Startgame.ShowDialog();
            Visible = true;

        }

        private void bStartGame_Click(object sender, EventArgs e)
        {
            MP Startgame = new MP(true);
            Visible = false;
            if (!Startgame.IsDisposed)
                Startgame.ShowDialog();
            Visible = true;
        }
    }
}
