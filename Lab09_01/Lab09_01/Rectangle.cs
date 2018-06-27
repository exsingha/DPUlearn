using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_01
{
    class Rectangle : Shape, Comparable
    {
        private double _base;
        private double _height;

        public Rectangle(double b, double h)
        {
            _base = b;
            _height = h;
            area = _base * _height;
        }

        public override double getArea()
        {
            return area;
        }

        public int CompareTo(Shape s)
        {
            int retvalue = 0;
            double otherArea = ((Rectangle)s).getArea();
            if (area < otherArea)
            {
                retvalue = -1;
            }
            else
            {
                if (area > otherArea)
                {
                    retvalue = 1;
                }
                else retvalue = 0;
            }
            return retvalue;
        }
    }
}
