using System.Windows.Forms;

namespace JocMemory
{
    internal class Player
    {
        private string username;
        private string password;
        private int money;
        private Quest[] quests;

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
        public Quest[] Quests
        {
            get { return quests; }
            set { quests = value; }
        }


    }
}