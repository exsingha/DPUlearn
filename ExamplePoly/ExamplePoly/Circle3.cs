using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePoly
{
    class Circle3 : Shape
    {
        protected double radius;
        public Circle3(double r) : base()
        {
            radius = r;
        }
        public double getRadius()
        {
            return radius;
        }
        public override double getArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
