using System.Collections.Generic;
using System.Windows.Forms;

namespace JocMemory
{
    public class Player
    {
        private int playerId;
        private string username;
        private string password;
        private int money;
        private List<Quest> quests;

        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public List<Quest> Quests
        {
            get { return quests; }
            set { quests = value; }
        }


    }
}