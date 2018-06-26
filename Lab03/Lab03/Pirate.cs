using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Pirate
    {
        private string name;
        private string speciality;
        private int health;
        private Random rnd;
        private int num;
        private int num2;

        public Pirate()
        {

        }
        public Pirate(string _name, int _health)
        {
            name = _name;
            health = _health;
        }
        public Pirate(string namein,string specialityin, int healthin)
        {
            name = namein;
            speciality = specialityin;
            health = healthin;
        }

        public string getName()
        {
            return name;
        }
        public string getSpeciality()
        {
            return speciality;
        }
        public int getHealth()
        {
            return health;
        }
        public void printDetails()
        {
            //Console.WriteLine("----------------");
            //Console.WriteLine("Name       : "+ name);
            //Console.WriteLine("Speciality : "+ speciality);
            //Console.WriteLine("Health     : "+ health);
            Console.WriteLine(name+" "+health);
        }
        public void printDetails(string _name, int _health)
        {
            Console.WriteLine(_name+" "+_health);
        }
        public void printDetails(string _name, int _health, bool check)
        {
            if (check == true)
            {
                Console.WriteLine("\nWinner : " + _name + " " + _health);
            }
            else
            {
                Console.WriteLine("\nWinner : "+ _name + " " + _health);
            }
        }

        public void fight(Pirate _pirate)
        {
            rnd = new Random();


            do
            {
                num = rnd.Next(0, 2);
                num = rnd.Next(0, 2);
                num = rnd.Next(0, 2);

                if (num == 0)
                {
                    num2 = rnd.Next(1, 21);
                    health -= num2;

                    printDetails(getName(), getHealth());
                }
                else if (num == 1)
                {
                    num2 = rnd.Next(1, 21);
                    num2 = rnd.Next(1, 21);
                    _pirate.health -= num2;

                    printDetails(_pirate.getName(), _pirate.getHealth());
                }
                if(health < 0 || _pirate.getHealth() < 0)
                {
                    break;
                }
            } while (health > 0 || _pirate.getHealth() > 0);

            if (health > _pirate.getHealth())
            {
                printDetails(getName(), getHealth(),true);
            }
            else
            {
                printDetails(_pirate.getName(), _pirate.getHealth(),false);
            }
        }
    }
}
