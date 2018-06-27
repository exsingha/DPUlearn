using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    class Human : LivingThing
    {
        public override void walk()
        {
            Console.WriteLine("Human walks...");
            //throw new NotImplementedException();
        }
    }
}
