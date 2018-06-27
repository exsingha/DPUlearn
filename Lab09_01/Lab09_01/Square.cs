using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_01
{
    class Square : Rectangle
    {

        public Square(double side):base(side,side)
        {
        
        }
        public override double getArea()
        {
            return area;
        }
    }
}
