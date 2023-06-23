using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JocMemory
{
    public partial class fMultiGame : Form
    {
        const int READY_FOR_CHECK = 2;
        const int NEW_CARD = -1;
        const int HINT_COST = 100;
        Card c1, c2;
        private static Board board = new Board();
        int labelsClicked = 0;
        int score = 0;
        bool[] cardsTurned = new bool[Board.NR_CARDS];
        Player player;
        int moves = 0;
        int time = 0;
        int multiplayer = 1;
        int player2Id;
        bool turnOfPlayer;
        string ip;
        int port;
        public static string cardsOrder = "";
        public static bool ready;
        public static bool orderDone;
        bool boardBuilt = false;
        public static int tagFromNetwork;
        static TcpListener server;
        static TcpClient client;
        static NetworkStream stream;
        static StreamReader streamReader;
        static StreamWriter streamWriter;
        static public string message = "";
        static bool clientConnected;
        static bool boardReceived = false;
        bool isServer;

        public fMultiGame()
        {
            InitializeComponent();
        }

        public fMultiGame(Player player, bool isServer)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            c1 = new Card();
            c2 = new Card();
            this.player = player;
            lCoins.Text = "Coins : " + player.Money.ToString();
            lPlayerName.Text = player.Username;
            this.isServer = isServer;
            if (isServer == true)
            {
                turnOfPlayer = true;
                board.BuildBoard(pGame, listImages);
                foreach (Card card in board.cards)
                {
                    card.Label.Click += new EventHandler(Run);
                }
                Task t = Task.Factory.StartNew(() =>
                {
                    IPAddress ipAddress = IPAddress.Parse(fConnection.tbIP.Text);
                    int port = Convert.ToInt32(fConnection.tbPort.Text);

                    server = new TcpListener(ipAddress, port);

                    server.Start();
                    Debug.WriteLine("Server started. Waiting for clients...");

                    client = server.AcceptTcpClient();
                    Debug.WriteLine("Client connected.");

                    stream = client.GetStream();
                    streamReader = new StreamReader(stream);
                    streamWriter = new StreamWriter(stream);

                    SendData(message);

                    Debug.WriteLine(message);
                    while (true)
                    {
                        if(client.Connected)
                            ReceiveData();
                        else
                            client.Close();
                        //client.Close();
                        //Console.WriteLine("Client disconnected.");
                    }

                });
            }
            else
            {
                IPAddress ipAddress = IPAddress.Parse(fConnection.tbIP.Text);
                int port = Convert.ToInt32(fConnection.tbPort.Text);

                client = new TcpClient();

                try
                {
                    Task t = Task.Factory.StartNew(() =>
                    {
                        client.Connect(ipAddress, port);

                        Debug.WriteLine("Connected to server.");
                        clientConnected = true;
                        stream = client.GetStream();
                        streamReader = new StreamReader(stream);
                        streamWriter = new StreamWriter(stream);
                        SendData("Hello " + player.PlayerId);
                        // Receive response from the server
                        while (true)
                            ReceiveDataFromServer();

                        // Close the connection
                        //client.Close();
                        //Console.WriteLine("Connection closed.");
                    });
                    while (boardReceived == false) ;
                    board.BuildBoard(pGame, listImages, cardsOrder);
                    foreach (Card card in board.cards)
                    {
                        card.Label.Click += new EventHandler(Run);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            this.Show();
        }

        private void ReceiveDataFromServer()
        {
            message = streamReader.ReadLine();
            if (message.StartsWith("Hello "))
            {
                string[] data = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                this.player2Id = Convert.ToInt32(data[1]);
            }
            else if (message.StartsWith("Tabla "))
            {
                Debug.WriteLine(message);
                string[] data = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < data.Length; i++)
                {
                    cardsOrder += data[i] + " ";
                }
                boardReceived = true;
                SendData("Gata de joc");
            }
            else
            {
                string[] data = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int tag = Convert.ToInt32(data[0]);
                ShowCard(tag);
            }
        }

        private void SendData(string message)
        {
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }

        private void ReceiveData()
        {
            message = streamReader.ReadLine();
            if (message.StartsWith("Hello "))
            {
                string[] data = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                this.player2Id = Convert.ToInt32(data[1]);
                SendData("Hello " + player.PlayerId);
            }
            else if (message.StartsWith("Gata "))
            {
                string[] data = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            }
            else if (message.StartsWith("Inchide "))
            {
                client.Close();
                this.Close();   
            }
            else
            {
                string[] data = message.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int tag = Convert.ToInt32(data[0]);
                ShowCard(tag);
            }
        }

        public void Run(object sender, EventArgs e)
        {
            message = "";
            if (turnOfPlayer == true)
            {
                Label clickedLabel = sender as Label;
                clickedLabel.Enabled = false;
                labelsClicked++;
                int labelTag = (int)(clickedLabel.Tag);
                board.cards[labelTag].Label.Image = board.cards[labelTag].FrontImage;
                if (c1.Label.Enabled == false && c2.Label.Enabled == false) // au fost apasate 2 imagini
                    return;
                if (c1.Index == NEW_CARD)
                {
                    c1 = board.cards[labelTag] as Card;
                    c1.Label.Tag = labelTag;
                }
                else
                {
                    c2 = board.cards[labelTag] as Card;
                    c2.Label.Tag = labelTag;
                }
                SendData(labelTag.ToString() + " ");
                if (labelsClicked == READY_FOR_CHECK)
                {
                    BlockCards();
                    if (c1.Index != NEW_CARD && c2.Index != NEW_CARD && c1.Index == c2.Index)
                    {
                        cardsTurned[(int)c1.Label.Tag] = true;
                        cardsTurned[(int)c2.Label.Tag] = true;
                        c1 = new Card();
                        c2 = new Card();
                        score++;
                        lScore.Text = "Score : " + score.ToString();
                    }
                    else
                    {
                        tSwitch1.Start();
                        //SendData("Inchide "+ c1.Label.Tag+ " "+c2.Label.Tag);
                    }

                    UnblockCards();
                    labelsClicked = 0;
                    moves++;
                    GameEnded();
                    turnOfPlayer = false;
                }
            }

        }

        private void UnblockCards()
        {
            foreach (Card card in board.cards)
                card.Label.Enabled = true;
        }

        private void BlockCards()
        {
            foreach (Card card in board.cards)
                card.Label.Enabled = false;
        }

        private void btnHints_Click(object sender, EventArgs e)
        {
            if (player.Money >= HINT_COST)
            {
                player.Money = player.Money - HINT_COST;
                lCoins.Text = "Coins : " + player.Money.ToString();
                BlockCards();
                foreach (Card card in board.cards)
                {
                    if (cardsTurned[(int)card.Label.Tag] == false)
                        card.Label.Image = card.FrontImage;
                }
                tHints.Start();
            }
        }


        private void GameEnded()
        {
            foreach (bool b in cardsTurned)
            {
                if (b == false)
                    return;
            }
            if (isServer == true)
                fLogin.sqlUtility.AddMultiPlayerResult(player.PlayerId, player2Id, this.score);
            EndGameStats endGameStats = new EndGameStats(moves, time, score, multiplayer);
            fEndGame fEndGame = new fEndGame(player, endGameStats);
            this.Close();
        }

        private void MultiPlayerForm_Load(object sender, EventArgs e)
        {

        }

        private void tSwitch1_Tick(object sender, EventArgs e)
        {
            tSwitch1.Stop();
            board.cards[(int)c1.Label.Tag].Label.Image = board.cards[(int)c1.Label.Tag].BackImage;
            board.cards[(int)c2.Label.Tag].Label.Image = board.cards[(int)c2.Label.Tag].BackImage;
            c1.Label.Enabled = true;
            c2.Label.Enabled = true;
            c1 = new Card();
            c2 = new Card();
            c1.Index = c2.Index = -1;
        }

        private void fMultiGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(client.Connected)
                SendData("Inchide ");
            Thread.Sleep(2000);
            client.Close();
            fMenu fMenu = new fMenu(player.Username);
            fMenu.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowCard(int tag)
        {
            board.cards[tag].Label.Image = board.cards[tag].FrontImage;
            labelsClicked++;
            if (c1.Label.Enabled == false && c2.Label.Enabled == false) // au fost apasate 2 imagini
                return;
            if (c1.Index == NEW_CARD)
            {
                c1 = board.cards[tag] as Card;
                c1.Label.Tag = tag;
            }
            else
            {
                c2 = board.cards[tag] as Card;
                c2.Label.Tag = tag;
            }
            if (labelsClicked == READY_FOR_CHECK)
            {
                BlockCards();
                if (c1.Index != NEW_CARD && c2.Index != NEW_CARD && c1.Index == c2.Index)
                {
                    cardsTurned[(int)c1.Label.Tag] = true;
                    cardsTurned[(int)c2.Label.Tag] = true;
                    c1 = new Card();
                    c2 = new Card();
                }
                else
                {
                    //Debug.WriteLine(c1.Index + " " + c2.Index);
                    Thread.Sleep(500);
                    board.cards[(int)c1.Label.Tag].Label.Image = board.cards[(int)c1.Label.Tag].BackImage;
                    board.cards[(int)c2.Label.Tag].Label.Image = board.cards[(int)c2.Label.Tag].BackImage;
                    c1.Label.Enabled = true;
                    c2.Label.Enabled = true;
                    c1 = new Card();
                    c2 = new Card();
                    c1.Index = c2.Index = -1;
                }

                UnblockCards();
                labelsClicked = 0;
                moves++;
                GameEnded();
                turnOfPlayer = true;
            }
        }
    }
}
