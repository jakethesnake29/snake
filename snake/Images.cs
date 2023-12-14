using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace snake
{
    public static class Images
    {

        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Food = LoadImage("Food.png");
        
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");

        public readonly static ImageSource Body2 = LoadImage("Body P2.png");
        public readonly static ImageSource Head2 = LoadImage("Head P2.png");
        public readonly static ImageSource DeadHead2 = LoadImage("DeadHead P2.png");
        public readonly static ImageSource DeadBody2 = LoadImage("DeadBody P2.png");

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
