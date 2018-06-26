using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class PirateGang
    {
        private string name;
        private Pirate Leader = new Pirate();
        private Pirate[] Pirates = new Pirate[10];
        private int pirateCount=0;
        private int num;
        private Random rnd;

        public void setName(string namein)
        {
            name = namein;
        }
        public void setLeader(Pirate namein)
        {
            Leader = namein;
        }
        public Pirate getLeader()
        {
            return Leader;
        }
        public string getName()
        {
            return name;
        }
        public void addPirate(Pirate AddPirate)
        {
            Pirates[pirateCount] = AddPirate;
            pirateCount++;
        }
        public void printPiratesDetails()
        {
            Console.WriteLine("\n"+name);
            Console.WriteLine("count : "+pirateCount);
            for(int i = 0; i < pirateCount; i++)
            {
              Pirates[i].printDetails();
            }
        }
        public Pirate pickPirate()
        {
            rnd = new Random();
            num = rnd.Next(0, 2);

            return Pirates[num];
        }
    }
}
