using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int compareValue;

            Shape[] s1 = new Shape[2];
            Shape[] s = new Shape[6];
            s[0] = new Circle(1);
            s[1] = new Circle(2);
            Console.WriteLine("Circle s[0] have area = " + s[0].getArea());
            Console.WriteLine("Circle s[1] have area = " + s[1].getArea());
            compareValue = ((Circle)s[0]).CompareTo(s[1]);
            Console.WriteLine("Compare Circle(0) area to Circle(1) area: " +
                                   compareValue);
            s[2] = new Rectangle(10, 2);
            s[3] = new Rectangle(1, 2);
            Console.WriteLine("\nRectangle s[2] have area = " + s[2].getArea());
            Console.WriteLine("Rectangle s[3] have area = " + s[3].getArea());
            compareValue = ((Rectangle)s[2]).CompareTo(s[3]);
            Console.WriteLine("Compare Rectangle(2) area to Rectangle(3) area: " +
                                   compareValue);

            s[4] = new Square(2);
            s[5] = new Square(3);
            Console.WriteLine("\nSquare s[4] have area = " + s[4].getArea());
            Console.WriteLine("Square s[5] have area = " + s[5].getArea());
            compareValue = ((Square)s[4]).CompareTo(s[5]);
            Console.WriteLine("Compare Square(4) area to Square(5) area: " +
                                   compareValue);

            s1[0] = new Circle(5);
            s1[1] = new Rectangle(13, 2);
            Console.WriteLine("\nCircle s1[0] have area = " + s1[0].getArea());
            Console.WriteLine("Rectangle s1[1] have area = " + s1[1].getArea());
            compareValue = ((Circle)s1[0]).CompareTo(s1[1]);
            Console.WriteLine("Compare Circle(0) area to Rectangle(1) area: " +
                                   compareValue);




            //Circle c = new Circle(1);
            //Console.WriteLine("Circle c have area = " + c.getArea());
            //Rectangle r = new Rectangle(2, 3);
            //Console.WriteLine("Rectangle r have area = " + r.getArea());
            //Square s = new Square(2);
            //Console.WriteLine("Square s have area = " + s.getArea());

        }
    }
}
