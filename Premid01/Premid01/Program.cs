using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premid01
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("Building1",10);
            Building b2 = new Building("Building2", 5);
            Building b3 = new Building("Building3", 4);

            Room r131 = new Room("131",50);
            Room r132 = new Room("132", 50);
            Room r133 = new Room("133", 50);

            Room r211 = new Room("211", 30);
            Room r212 = new Room("212", 30);
            Room r221 = new Room("221", 30);
            Room r222 = new Room("222", 30);
            Room r233 = new Room("233", 30);

            Room r321 = new Room("321", 100);
            Room r331 = new Room("331", 100);

            

            b1.addRoom(r131);
            b1.addRoom(r132);
            b1.addRoom(r133);

            b2.addRoom(r211);
            b2.addRoom(r212);
            b2.addRoom(r221);
            b2.addRoom(r222);
            b2.addRoom(r233);

            b3.addRoom(r321);
            b3.addRoom(r331);

            Console.Write("Please Enter the number of people: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //System.Threading.Thread.Sleep(5000);

            b1.getRoom(num);
            b2.getRoom(num);
            b3.getRoom(num);

            //b1.PrintDetails();
            //Console.WriteLine();
            //b2.PrintDetails();
            //Console.WriteLine();
            //b3.PrintDetails();

        }
    }
}
