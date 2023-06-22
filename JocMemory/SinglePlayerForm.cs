using Org.BouncyCastle.Asn1.Ess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JocMemory
{
    public partial class fSingleGame : Form
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
        int multiplayer = 0;
        public fSingleGame()
        {
            InitializeComponent();
        }

        public fSingleGame(Player player)
        {
            InitializeComponent();
            c1 = new Card();
            c2 = new Card();
            this.player = player;
            lCoins.Text = "Coins : " + player.Money.ToString();
            lPlayerName.Text = player.Username;
            this.Show();
            board.BuildBoard(pGame, listImages);
            foreach (Card card in board.cards)
            {
                card.Label.Click += new EventHandler(Run);
            }
            tSeconds.Start();
        }

        public void Run(object sender, EventArgs e)
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

        private void GameEnded()
        {
            foreach (bool b in cardsTurned)
            {
                if (b == false)
                    return;
            }
            tSeconds.Stop();
            EndGameStats endGameStats = new EndGameStats(moves,time,score,multiplayer);
            fEndGame fEndGame = new fEndGame(player, endGameStats);
            this.Close();
            //form result final plus verificare quest-uri
        }

        private void tSwitch_Tick(object sender, EventArgs e)
        {
            tSwitch.Stop();
            board.cards[(int)c1.Label.Tag].Label.Image = board.cards[(int)c1.Label.Tag].BackImage;
            board.cards[(int)c2.Label.Tag].Label.Image = board.cards[(int)c2.Label.Tag].BackImage;
            c1.Label.Enabled = true;
            c2.Label.Enabled = true;
            c1 = new Card();
            c2 = new Card();
            c1.Index = c2.Index = -1;
        }

        private void btnHints_Click(object sender, EventArgs e)
        {
            if (player.Money >= HINT_COST)
            {
                player.Money = player.Money-HINT_COST;
                lCoins.Text="Coins : "+player.Money.ToString();
                BlockCards();
                foreach (Card card in board.cards)
                {
                    if (cardsTurned[(int)card.Label.Tag] == false)
                        card.Label.Image = card.FrontImage;
                }
                tHints.Start();
            }
        }

        private void tSeconds_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void tHints_Tick(object sender, EventArgs e)
        {
            tHints.Stop();
            foreach (Card card in board.cards)
            {
                if (cardsTurned[(int)card.Label.Tag] == false)
                    card.Label.Image = card.BackImage;
            }
            UnblockCards();
        }

        private void SinglePlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
