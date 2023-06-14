namespace JocMemory
{
    internal class Requirment
    {
        private string objectiveName;
        private int objectiveAmount;

        public string ObjectiveName 
        { 
            get { return objectiveName; }
            set { objectiveName = value; }
        }

        public int ObjectiveNumber
        {
            get { return objectiveAmount; }
            set { objectiveAmount = value; }
        }

    }
}