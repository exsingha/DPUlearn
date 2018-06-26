using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MountainBike a = new MountainBike(1, 1, 10, 1);
            Console.WriteLine("Gear  : " + a.gear);
            Console.WriteLine("Speed : " + a.speed);
            Console.WriteLine("===========");
            for (int i = 2; i <= 5; i++)
            {
                a.setGear(i);
                a.speedUp(10);
                a.applyBrake(3);

                Console.WriteLine("Gear  : " + a.gear);
                Console.WriteLine("Speed : " + a.speed);
                Console.WriteLine("===========");

            }
        }
    }
}
