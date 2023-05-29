namespace JocMemory
{
    internal class Quest
    {
        private string name;
        private Requirment[] requirments;
        private int reward;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}