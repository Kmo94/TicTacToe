using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
namespace TicTacToeClient
{
    public partial class Play : Form
    {
        
        typeOfGame type;
        int choice = 0;
        TcpListener listener;
        Thread threadPlayer1 = null;
        Thread threadPlayer2 = null;
        private const string hostName = "localhost";
        int player1, player2,ties;
        Boolean playerturn, cputurn;
        List<Button> XOButtonsAvailable;
        delegate void SetTextCallback(string text);
        TcpClient client;
        NetworkStream ns = default(NetworkStream);
       
        
        string playerCharacter, otherPlayerCharacter;
        public Play(typeOfGame t1, string pchoice)
        {
            type = t1;
            InitializeComponent();
            playerCharacter = pchoice;
            restart();
            
        }
        public Play(typeOfGame t1)
        {
            InitializeComponent();
            type = t1;
            playerCharacter = "X";
            otherPlayerCharacter = "O";
            restart();
        }

        private void lblPlayerTwo_Click(object sender, EventArgs e)
        {

        }

        private void Play_Load(object sender, EventArgs e)
        {
            if (type == typeOfGame.playvsfriend)
            {
                try
                {

                    client = new TcpClient(hostName, Form1.ptNum);
                    playerCharacter = "O";
                    otherPlayerCharacter = "X";
                    ns = client.GetStream();
                    playerturn = false;
                    threadPlayer2 = new Thread(getMoves);
                    threadPlayer2.IsBackground = true;
                    threadPlayer2.Start();
                }

                catch (SocketException se)
                {
                    MessageBox.Show("Connection to server, could not be made..");

                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();

                }
            }
       
          
            if (type == typeOfGame.playvscpu)
            {

                if (playerCharacter == "X")
                {
                    otherPlayerCharacter = "O";
                }
                else
                {
                    otherPlayerCharacter = "X";
                }
            }
            btnPosOne.Click += Button_Click;
            btnPosTwo.Click += Button_Click;
            btnPosThree.Click += Button_Click;
            btnPosFour.Click += Button_Click;
            btnPosFive.Click += Button_Click;
            btnPosSix.Click += Button_Click;
            btnPosSeven.Click += Button_Click;
            btnPosEight.Click += Button_Click;
            btnPosNine.Click += Button_Click;
         
        }
      

        
        private void Button_Click(object sender, EventArgs e)
        {
            string s;
            if (playerturn == true)
            {
                if (type == typeOfGame.playvscpu)
                {
                    var button = (Button)sender;
                    button.Text = playerCharacter;
                    button.Enabled = false;
                    XOButtonsAvailable.Remove(button);
                    Didyouwin();
                    CpuMoves();
                    CpuTimer.Start();
                    playerturn = false;
                    cputurn = true;
                }
                else if (type == typeOfGame.playvsfriend)
                {
                    if (client.Connected)
                    {
                        var button = (Button)sender;
                        button.Text = playerCharacter;
                        s = Convert.ToString(XOButtonsAvailable.IndexOf(button));
                        XOButtonsAvailable.Remove(button);
                        button.Enabled = false;


                        byte[] outStream = System.Text.Encoding.ASCII.GetBytes(s);
                        ns.Write(outStream, 0, outStream.Length);


                        playerturn = false;

                        Didyouwin();
                    }
                    else
                    {
                        MessageBox.Show("Connection Lost!");
                    }

                       
                }
                else if (type == typeOfGame.playvsfriendHost)
                {
                    var button = (Button)sender;
                    button.Text = playerCharacter;
                    s = Convert.ToString(XOButtonsAvailable.IndexOf(button));
                    XOButtonsAvailable.Remove(button);
                    button.Enabled = false;
                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(s);
                    ns.Write(outStream, 0, outStream.Length);
                    Didyouwin();
                    threadPlayer1 = new Thread(getMoves);
                    threadPlayer1.IsBackground = true;
                    threadPlayer1.Start();
                    playerturn = false;

                }
            }
          
        }
        private void getMoves()
        {
            byte[] inStreamm = new byte[1024];
            try
            {
                while (true)
                {

                    if (client.Connected)
                    {

                        string readOtherPlayerMoves;


                        int bytesRead = ns.Read(inStreamm, 0, inStreamm.Length);
                        readOtherPlayerMoves = System.Text.Encoding.ASCII.GetString(inStreamm, 0, bytesRead);
                        if (readOtherPlayerMoves != string.Empty)
                        {
                            writeMoves(readOtherPlayerMoves);
                            playerturn = true;
                        }
                    }
                    
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Lost");
                threadPlayer2.Abort();
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }

        }

        private void writeMoves(string text)
        {
            playerturn = true;
            if (this.XOButtonsAvailable[Convert.ToInt32(text)].InvokeRequired)
            {
                SetTextCallback del = new SetTextCallback(writeMoves);
                this.Invoke(del, new object[] { text });
            }

            else
            {
                XOButtonsAvailable[Convert.ToInt32(text)].Text = otherPlayerCharacter;
                XOButtonsAvailable[Convert.ToInt32(text)].Enabled = false;
                XOButtonsAvailable.RemoveAt(Convert.ToInt32(text));
                Didyouwin();
            }
                
           
           
        }
        private void addBtnsToList()
        {
            XOButtonsAvailable = new List<Button>{btnPosOne, btnPosTwo, btnPosThree, btnPosFour, btnPosFive, btnPosSix, btnPosSeven, btnPosEight, btnPosNine};
        }
        private void Didyouwin()
        {
            if (btnPosOne.Text == playerCharacter && btnPosTwo.Text == playerCharacter && btnPosThree.Text == playerCharacter ||
                btnPosFour.Text == playerCharacter && btnPosFive.Text == playerCharacter && btnPosSix.Text == playerCharacter ||
                btnPosSeven.Text == playerCharacter && btnPosEight.Text == playerCharacter && btnPosNine.Text == playerCharacter ||
                btnPosTwo.Text == playerCharacter && btnPosFive.Text == playerCharacter && btnPosEight.Text == playerCharacter ||
                btnPosThree.Text == playerCharacter && btnPosSix.Text == playerCharacter && btnPosNine.Text == playerCharacter ||
                btnPosOne.Text == playerCharacter && btnPosFive.Text == playerCharacter && btnPosNine.Text == playerCharacter ||
                btnPosOne.Text == playerCharacter && btnPosFour.Text == playerCharacter && btnPosSeven.Text == playerCharacter ||
                btnPosThree.Text == playerCharacter && btnPosFive.Text == playerCharacter && btnPosSeven.Text == playerCharacter)
            {
                MessageBox.Show("You win!");
                
                    player1++;
                    lblPlayerOne.Text = "Player 1: " +  player1;
                    restart();
                

            }
            else if (btnPosOne.Text == otherPlayerCharacter && btnPosTwo.Text == otherPlayerCharacter && btnPosThree.Text == otherPlayerCharacter ||
                btnPosFour.Text == otherPlayerCharacter && btnPosFive.Text == otherPlayerCharacter && btnPosSix.Text == otherPlayerCharacter ||
                btnPosSeven.Text == otherPlayerCharacter && btnPosEight.Text == otherPlayerCharacter && btnPosNine.Text == otherPlayerCharacter ||
                btnPosTwo.Text == otherPlayerCharacter && btnPosFive.Text == otherPlayerCharacter && btnPosEight.Text == otherPlayerCharacter ||
                btnPosThree.Text == otherPlayerCharacter && btnPosSix.Text == otherPlayerCharacter && btnPosNine.Text == otherPlayerCharacter ||
                btnPosOne.Text == otherPlayerCharacter && btnPosFive.Text == otherPlayerCharacter && btnPosNine.Text == otherPlayerCharacter ||
                btnPosOne.Text == otherPlayerCharacter && btnPosFour.Text == otherPlayerCharacter && btnPosSeven.Text == otherPlayerCharacter ||
                btnPosThree.Text == otherPlayerCharacter && btnPosFive.Text == otherPlayerCharacter && btnPosSeven.Text == otherPlayerCharacter)
            {
                if (type == typeOfGame.playvscpu)
                {
                    MessageBox.Show("CPU Wins!");
                    player2++;
                    lblPlayerTwo.Text = "Cpu wins: " + player2;
                    restart();
                }
                else if (type == typeOfGame.playvsfriend)
                {
                    MessageBox.Show("Player 2 Won!");
                    player2++;
                    lblPlayerTwo.Text = "Player 2: " + player2;
                    restart();
                }

            }
            else if (XOButtonsAvailable.Count == 0)
            {
                MessageBox.Show("Tie!");
                ties++;
                lblTies.Text = "Ties :" + ties;
                restart();
            }
        }
        private void CpuMoves(object sender, EventArgs e)
        {
            if (cputurn == true)
            {
                if (XOButtonsAvailable.Count > 0)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(XOButtonsAvailable.Count);
                    XOButtonsAvailable[index].Text = otherPlayerCharacter;
                    XOButtonsAvailable[index].Enabled = false;
                    XOButtonsAvailable.RemoveAt(index);
                    Didyouwin();


                }
                CpuTimer.Stop();
                playerturn = true;
                cputurn = false;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void restart()
        {
            btnPosOne.Enabled = true;
            btnPosOne.Text = string.Empty;
            btnPosTwo.Enabled = true;
            btnPosTwo.Text = string.Empty;
            btnPosThree.Enabled = true;
            btnPosThree.Text = string.Empty;
            btnPosFour.Enabled = true;
            btnPosFour.Text = string.Empty;
            btnPosFour.Enabled = true;
            btnPosFive.Enabled = true;
            btnPosFive.Text = string.Empty;
            btnPosSix.Enabled = true;
            btnPosSix.Text = string.Empty;
            btnPosSeven.Enabled = true;
            btnPosSeven.Text = string.Empty;
            btnPosEight.Enabled = true;
            btnPosEight.Text = string.Empty;
            btnPosNine.Enabled = true;
            btnPosNine.Text = string.Empty;
            addBtnsToList();
            playerturn = true;
            cputurn = false;
        }

        private void CpuMoves()
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            restart();
            if (threadPlayer2!= null)
            {
                threadPlayer2.Abort();
                client.Close();
                ns.Dispose();
                restart();
            }
            
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

 
        
    }
}
