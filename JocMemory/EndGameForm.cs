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
    public partial class fEndGame : Form
    {
        Player player;
        public fEndGame()
        {
            InitializeComponent();
        }

        public fEndGame(Player player, EndGameStats endGameStats)
        {
            InitializeComponent();
            this.player = player;
            listEnd.Items.Add("Congratulations!!!!");
            listEnd.Items.Add("Your stats : ");
            listEnd.Items.Add("Time : " + endGameStats.Time.ToString() + " seconds");
            listEnd.Items.Add("Moves : " + endGameStats.Moves.ToString());
            listEnd.Items.Add("Score : " + endGameStats.Score.ToString());
            CheckForCompletedQuests(player.Quests, endGameStats);
            fLogin.sqlUtility.UpdatePlayerCoins(player);
            fLogin.sqlUtility.AddSinglePlayerResult(player.PlayerId, endGameStats.Score, endGameStats.Time);
            this.Show();
        }

        private void CheckForCompletedQuests(List<Quest> quests, EndGameStats endGameStats)
        {
            int questCompleted;
            foreach (Quest quest in quests)
            {
                questCompleted = quest.Requirements.Count;
                int requirementsCompleted = 0;
                foreach (Requirement requirement in quest.Requirements)
                {
                    switch (requirement.ObjectiveName)
                    {
                        case "moves":
                            {
                                if (requirement.ObjectiveAmount >= endGameStats.Moves)
                                    requirementsCompleted++;
                                break;
                            }
                        case "time":
                            {
                                if (requirement.ObjectiveAmount >= endGameStats.Time)
                                    requirementsCompleted++;
                                break;
                            }
                        case "score":
                            {
                                if (requirement.ObjectiveAmount <= endGameStats.Score)
                                    requirementsCompleted++;
                                break;
                            }
                        case "multiplayer":
                            {
                                if (requirement.ObjectiveAmount == endGameStats.Multiplayer)
                                    requirementsCompleted++;
                                break;
                            }
                    }
                }
                if (requirementsCompleted == questCompleted)
                {
                    listEnd.Items.Add(quest.Name + "  R : " + quest.Reward.ToString());
                    player.Money += quest.Reward;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fMenu fMenu = new fMenu(player.Username);
            fMenu.Show();
            this.Close();
        }
    }
}
