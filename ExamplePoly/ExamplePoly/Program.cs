using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myShape;
            myShape = new Rectangle(10.0, 20.0);
            Console.WriteLine(myShape.getArea());
            myShape = new Circle3(10.0);
            Console.WriteLine(myShape.getArea());
        }
    }
}
