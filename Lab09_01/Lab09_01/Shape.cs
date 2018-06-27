using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_01
{
    public abstract class Shape
    {
        protected double area;
        public Shape()
        {

        }
        public abstract double getArea();
    }
}
