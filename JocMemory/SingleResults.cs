namespace JocMemory
{
    internal class SingleResults
    {
        private int resultId;
        private int playerId;
        private int score;
        private int time;

        public int ResultId
        {
            get { return resultId; }
            set { resultId = value; }
        }

        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}