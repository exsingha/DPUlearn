using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Pirate
    {
        private string name;
        private int health;

        public void setName(string _name)
        {
            name = _name;
        }
        public void setHealth(int _health)
        {
            health = _health;
        }
        public string getName()
        {
            return name;
        }
        public int getHealth()
        {
            return health;
        }
        public void printDetails()
        {
            Console.WriteLine("pirate name : "+name);
            Console.WriteLine("health      : "+health);
        }
        public void fight(Pirate _pirate)
        {

        }
    }
}
