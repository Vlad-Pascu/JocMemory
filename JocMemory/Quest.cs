using System.Collections.Generic;

namespace JocMemory
{
    public class Quest
    {
        private int questId;
        private string name;
        private List<Requirement> requirements;
        private int reward;

        public int QuestId
        {
            get { return questId; }
            set { questId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Requirement> Requirements
        {
            get { return requirements; }
            set { requirements = value; }
        }

        public int Reward
        {
            get { return reward; }
            set { reward = value; }
        }
    }
}