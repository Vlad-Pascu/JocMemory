using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace JocMemory
{
    public class Card
    {
        static int[] indexUsed = new int[Board.NR_CARDS]; 
        Label label=new Label();
        private Bitmap backImage, frontImage;
        private int index;
        public const int LABEL_SIZE=70;
        Random random= new Random();

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public Bitmap BackImage
        {
            get { return backImage; }
            set { backImage = value; }
        }

        public Bitmap FrontImage
        {
            get { return frontImage; }
            set { frontImage = value; }
        }

        public Label Label
        { get { return label; } }
        public Card(int x,int y, Panel panel, int index)
        {
            backImage = (Bitmap)Bitmap.FromFile(@"D:\Facultate\ANUL_4\Licenta\JocMemory\Images\14.bmp");
            label.Width =label.Height=LABEL_SIZE;
            label.Image = backImage;
            label.Left = x;
            label.Top = y;
            label.Tag = index;
            panel.Controls.Add(label);
        }

        public Card()
        {
            index = -1;
        }


        public void SetImageOnCard(ImageList imageList) 
        {
            int tempIndex = 0;
            tempIndex= random.Next(Board.NR_CARDS);
            while(indexUsed[tempIndex]!=0)
                tempIndex=random.Next(Board.NR_CARDS);
            indexUsed[tempIndex]=1;
            index=tempIndex;
            frontImage = (Bitmap)imageList.Images[index];
            index = index % 14;
        }
    }
}