using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace OOPLecture07_05
{
    class Pirate
    {
        private string name;
        private int health;
        private string imagename;
        private BitmapImage imagesource;

        public string Name { get => name; set => name = value;  }
        public string ImageName { get => imagename; set => imagename = value; }

        public int Health { get => health; set => health = value; }
        public BitmapImage ImageSource { get => imagesource; set => imagesource = value; }


        public Pirate(string n, int h)
        {
            Name = n;
            Health = h;
            ImageName = "/images/" + Name + ".jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(ImageName, UriKind.Relative);
            bitmap.EndInit();
            ImageSource = bitmap;
        }
    }
}
