using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_01
{
    class Circle : Shape, Comparable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            area = 3.1416 * radius * radius;
        }
        public override double getArea()
        {
            return area;
        }

        public int CompareTo(Shape s)
        {
            int retvalue = 0;
            double otherArea = ((Shape)s).getArea();
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
