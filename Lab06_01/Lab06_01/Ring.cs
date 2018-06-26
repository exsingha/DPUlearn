using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_01
{
    class Ring : Circle1
    {
        private double innerR;

        public Ring() : base()
        {
            innerR = 0.0;
        }
        public Ring(double innerR, int position_X, int position_Y, double radius) : base(position_X, position_Y, radius)
        {
            this.innerR = innerR;
        }
        public override double calArea()
        {
            area = (Math.PI * radius * radius) - (Math.PI * innerR * innerR);
            return area;
        }
    }
}
