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
    public partial class fMenu : Form
    {
        Player player;
        public fMenu()
        {
            InitializeComponent();
        }

        public fMenu(string username)
        {
            InitializeComponent();
            player = fLogin.sqlUtility.GetPlayerByUsername(username);
            lCoins.Text = "Coins : "+ player.Money.ToString();
            lPlayerName.Text += player.Username;
            player.Quests = fLogin.sqlUtility.GetQuestForPlayer(player.PlayerId);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void fMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnQuests_Click(object sender, EventArgs e)
        {
            fQuests fQuests= new fQuests(player.Quests);
            fQuests.Show();
            this.Hide();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            fSingleGame fSingleGame= new fSingleGame(player);
            this.Hide();
        }
    }
}
