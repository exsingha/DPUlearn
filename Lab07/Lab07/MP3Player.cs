using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class MP3Player : Electronics
    {
        private string color;
        public MP3Player(double regularPrice, string manufacturer, string color) : base(regularPrice, manufacturer)
        {
            this.color = color;
        }
        public override double computeSalePrice()
        {
            return base.getRegularPrice() * 0.9;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }
    }
}
