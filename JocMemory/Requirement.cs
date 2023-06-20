using Org.BouncyCastle.Asn1.Mozilla;

namespace JocMemory
{
    public class Requirement
    {
        private int requirementId;
        private string objectiveName;
        private int objectiveAmount;

        public int RequirementId
        {
            get { return requirementId; }
            set { requirementId= value; }
        }

        public string ObjectiveName 
        { 
            get { return objectiveName; }
            set { objectiveName = value; }
        }

        public int ObjectiveAmount
        {
            get { return objectiveAmount; }
            set { objectiveAmount = value; }
        }

    }
}