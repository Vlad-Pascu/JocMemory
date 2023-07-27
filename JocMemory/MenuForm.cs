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
        Player player=null;
        public fMenu()
        {
            InitializeComponent();
        }

        public fMenu(string username)
        {
            InitializeComponent();
            player = fLogin.sqlUtility.GetPlayerByUsername(username);
            if (username.StartsWith("Guest"))
            {
                player = new Player();
                player.Username = "Guest";
                player.Money= 0;
                player.Quests = null;
                lCoins.Text = "Coins : "+ player.Money;
                lPlayerName.Text += player.Username;
                btnMultiPlayer.Enabled= false;
                btnQuests.Enabled= false;
            }
            else
            {
                lCoins.Text = "Coins : " + player.Money;
                lPlayerName.Text += player.Username;
                player.Quests = fLogin.sqlUtility.GetQuestForPlayer(player.PlayerId);
            }
            
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
            //System.Windows.Forms.Application.Exit();
            this.Hide();
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

        private void btnMultiPlayer_Click(object sender, EventArgs e)
        {
            fConnection fConnection= new fConnection(player);
            fConnection.Show();
            this.Hide();
        }

        private void btnHelpResults_Click(object sender, EventArgs e)
        {
            fHelpResult fHelpResult= new fHelpResult(player);
            fHelpResult.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin fLogin = new fLogin();
            fLogin.Show();
            this.Close();
        }
    }
}
