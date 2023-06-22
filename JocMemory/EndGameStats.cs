namespace JocMemory
{
    public class EndGameStats
    {
        private int moves;
        private int time;
        private int score;
        private int multiplayer;

        public int Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Multiplayer
        {
            get { return multiplayer; }
            set { multiplayer = value; }
        }

        public EndGameStats(int moves,int time, int score, int multiplayer) 
        { 
            this.moves = moves;
            this.time = time;
            this.score = score;
            this.multiplayer = multiplayer;
        }
    }
}