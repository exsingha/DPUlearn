﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Lab10
{
    class Pirate
    {
        //private string name;
        //private string imagename;

        //public Pirate(string _name)
        //{
        //    Name = _name;
        //    imagename = "/OOPLecture07_04;component/Images/" + name + ".jpg";
        //}
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
        //public string GetImageName()
        //{
        //    return imagename;
        //}
            private string name;
            private int health;
            private string imagename;
            private BitmapImage imagesource;

            public string Name { get => name; set => name = value; }
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
