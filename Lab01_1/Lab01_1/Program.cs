using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please Enter a radius: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            //double area = 3.14 * r * r;
            //Console.WriteLine("The Circle area = " + area);
            Console.Write("Please Enter a Numer for x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter a Numer for y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x+y = " + (x + y));
            Console.WriteLine("x-y = " + (x - y));
            Console.WriteLine("x*y = " + (x * y));
            Console.WriteLine("x/y = " + (x / y));

        }
    }
}
