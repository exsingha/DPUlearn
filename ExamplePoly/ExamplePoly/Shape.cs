using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePoly
{
    class Shape
    {
        protected string color;

        public Shape()
        {
            color = "Red";
        }
        public virtual double getArea()
        {
            return 0;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
    }
}
