using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocMemory
{
    public partial class fMultiGame : Form
    {
        const int READY_FOR_CHECK = 2;
        const int NEW_CARD = -1;
        const int HINT_COST = 100;
        Card c1, c2;
        private Board board = new Board();
        int labelsClicked = 0;
        int score = 0;
        bool[] cardsTurned = new bool[Board.NR_CARDS];
        Player player;
        int moves = 0;
        int time = 0;
        int multiplayer = 1;
        int player2Id;
        bool turnOfPlayer;
        static public bool isServer, isClient;
        string ip;
        int port;
        public static string cardsOrder = "";
        public static bool ready;
        public static bool orderDone;

        public fMultiGame()
        {
            InitializeComponent();
        }

        public fMultiGame(Player player, int player2Id)
        {
            InitializeComponent();
            c1 = new Card();
            c2 = new Card();
            this.player = player;
            this.player2Id = player2Id;
            lCoins.Text = "Coins : " + player.Money.ToString();
            lPlayerName.Text = player.Username;
            if (isServer == true)
            {
                turnOfPlayer= true;
                fConnection.messageSend = "Tabla ";
                board.BuildBoard(pGame, listImages);
                foreach (Card card in board.cards)
                {
                    card.Label.Click += new EventHandler(Run);
                }
            }
            else if (isClient == true)
            {
                turnOfPlayer= false;
                fConnection.messageSend = "Gata de joc";
                //fConnection.client.WriteLine(fConnection.messageSend);
                
            }
            this.Show();
            //BlockCards();
            //while (ready == false) ;
            //UnblockCards();
        }

        public void Run(object sender, EventArgs e)
        {
            fConnection.messageSend = "Carte ";
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
            fConnection.messageSend += labelTag.ToString();
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
                    tSwitch.Start();
                UnblockCards();
                labelsClicked = 0;
                moves++;
                GameEnded();
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isServer == true)
                fConnection.server.BroadcastLine(fConnection.messageSend);
            else
            {
                board.BuildBoard(pGame, listImages, cardsOrder);
                foreach (Card card in board.cards)
                {
                    card.Label.Click += new EventHandler(Run);
                }
            }
                
        }

        private void GameEnded()
        {
            foreach (bool b in cardsTurned)
            {
                if (b == false)
                    return;
            }
            EndGameStats endGameStats = new EndGameStats(moves, time, score, multiplayer);
            fEndGame fEndGame = new fEndGame(player, endGameStats);
            this.Close();
            //form result final plus verificare quest-uri
        }

        private void MultiPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
