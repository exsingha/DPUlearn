using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture02
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSpeed car = new CarSpeed();
            car.SetSpeed(55);

            Console.WriteLine("speed : "+car.GetSpeed());
            
        }
    }
}
