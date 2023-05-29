using System.Drawing;
using System.Windows.Forms;

namespace JocMemory
{
    internal class Card : Position
    {
        private Image backImage, frontImage;
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        
        public Card(int x,int y,Panel panel) { }

        public void SetImageOnCard() { }
    }
}