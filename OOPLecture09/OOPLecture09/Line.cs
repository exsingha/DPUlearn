using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    class Line : Relation
    {
        private double x1;
        private double x2;
        private double y1;
        private double y2;

        public Line(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            
        }
        public double getLength()
        {
            double length = Math.Sqrt((x2 - x1)*(x2-x1)+(y2-y1)*(y2-y1));
            return length;
        }
        public bool isGreater(Object a, Object b)
        {
            double aLen = ((Line)a).getLength();
            double bLen = ((Line)b).getLength();
            return (aLen > bLen);
        }

        public bool isEqual(object a, object b)
        {
            double aLen = ((Line)a).getLength();
            double bLen = ((Line)b).getLength();
            return (aLen == bLen);
        }

        public bool isLess(object a, object b)
        {
            double aLen = ((Line)a).getLength();
            double bLen = ((Line)b).getLength();
            return (aLen < bLen);
        }
    }
}
