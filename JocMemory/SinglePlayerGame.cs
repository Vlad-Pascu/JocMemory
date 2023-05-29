using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocMemory
{
    internal class SinglePlayerGame:Game
    {
        private Board board;
        private Player player;

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }
        //private SQLUtility sql;
        public void Run() { }
    }
}
