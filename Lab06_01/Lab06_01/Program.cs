using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle1 c1;
            c1 = new Circle1(3, 2, 5.0);

            //Circle1 c1 = new Circle1(3, 2, 5.0);
            //Ring r1 = new Ring(2.0, 4, 7, 5.0);

            Console.WriteLine("c1.calArea() : {0}",c1.calArea());
            c1 = new Ring(2.0, 4, 7, 5.0);
            Console.WriteLine("r1.calArea() : {0}",c1.calArea());

        }
    }
}
