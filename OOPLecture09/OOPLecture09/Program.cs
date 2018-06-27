using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human h = new Human();

            //h.breath();
            //h.eat();
            //h.walk();

            //Monkey m = new Monkey();
            //m.breath();
            //m.eat();
            //m.walk();
            Line l1 = new Line(0, 5, 0, 10);
            Line l2 = new Line(0, 10, 0, 10);
            Console.WriteLine("l1 Length : "+l1.getLength());
            Console.WriteLine("l2 length : "+l2.getLength());
            Console.WriteLine("l1 is greater than l2? {0}"
                ,l1.isGreater(l1,l2));
            Console.WriteLine("l1 is Less than l2? {0}"
                , l1.isLess(l1, l2));
        }
    }
}
