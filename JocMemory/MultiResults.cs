namespace JocMemory
{
    internal class MultiResults
    {
        private int resultId;
        private int player1Id;
        private int player2Id;
        private int score1;
        private int score2;

        public int ResultId
        {
            get { return resultId; }
            set { resultId = value; }
        }

        public int Player1Id
        {
            get { return player1Id; }
            set { player1Id = value; }
        }

        public int Player2Id
        {
            get { return player2Id; }
            set { player2Id = value; }
        }

        public int Score1
        {
            get { return score1; }
            set { score1 = value; }
        }

        public int Score2
        {
            get { return score2; }
            set { score2 = value; }
        }
    }
}