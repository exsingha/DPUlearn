using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePoly
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h) : base()
        {
            width = w;
            height = h;
        }
        public double getWidth()
        {
            return width;
        }
        public double getHeight()
        {
            return height;
        }
        public override double getArea()
        {
            return width * height;
        }
    }
}
