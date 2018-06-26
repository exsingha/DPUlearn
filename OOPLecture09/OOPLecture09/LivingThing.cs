using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    abstract class LivingThing
    {
        public void breath()
        {
            Console.WriteLine("Living Thing breathing...");
        }
        public void eat()
        {
            Console.WriteLine("Living Thing eating...");
        }
        public abstract void walk();
    }
}
