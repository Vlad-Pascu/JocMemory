using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocMemory
{
    public class Board
    {
        const int MARGINX = 30;
        const int PADDING = 25;
        public const int NR_CARDS = 28;
        public Card[] cards = new Card[NR_CARDS];
        public void BuildBoard(Panel panel, ImageList imageList, string cardsOrder = "")
        {
            int k = 0;
            string[] data = null;
            if (cardsOrder!="")
                data = cardsOrder.Split(' ');
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    cards[k] = new Card(MARGINX + (j * (Card.LABEL_SIZE + PADDING)),
                                        MARGINX + (i * (Card.LABEL_SIZE + PADDING)),
                                        panel, k);

                    if (data == null)
                        cards[k].SetImageOnCard(imageList);
                    else
                        cards[k].SetImageOnCard(imageList, data[k]);
                    k++;
                }
            }
        }
    }
}
