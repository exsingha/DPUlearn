using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_01
{
    class Circle1
    {
        protected int position_X;
        protected int position_Y;
        protected double radius;
        protected double area;
        protected double circumference;

        public Circle1()
        {
            position_X = 0;
            position_Y = 0;
            radius = 0.0;
            area = 0.0;
            circumference = 0.0;
        }
        public Circle1(int position_X, int position_Y, double radius)
        {
            this.position_X = position_X;
            this.position_Y = position_Y;
            this.radius = radius;
        }
        public double calArea(double newRadius) //พื้นที่
        {
            area = Math.PI * newRadius * newRadius;
            return area;
        }
        public double calCircumference(double newRadius) //เส้นรอบวง
        {
            circumference = Math.PI * newRadius * newRadius;
            return circumference;
        }
        public virtual double calArea()
        {
            area = Math.PI * radius * radius;
            return area;
        }
        public double calCircumference()
        {
            circumference = 2 * Math.PI * radius;
            return circumference;
        }
        public int Position_X
        {
            get
            {
                return position_X;
            }
            set
            {
                position_X = value;
            }
        }
        public int Position_Y
        {
            get
            {
                return position_Y;
            }
            set
            {
                position_Y = value;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
    }
}
