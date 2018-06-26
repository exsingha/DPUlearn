using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate blind = new Pirate();
            Random rnd = new Random();
            int num;
            int num2;
            int num3;
            int num4;
            //Pirate Luffy = new Pirate("Luffy", "RubberBody", 80);
            //Pirate Zoro = new Pirate("Zoro", "SwordMan", 100);
            //Pirate Usopp = new Pirate("Usopp", "Inventor", 20);
            //Pirate Nami = new Pirate("Nami", "Thief", 50);
            //Pirate Sanji = new Pirate("Sanji", "Cook", 60);
            
            num = rnd.Next(1, 101);
            num2 = rnd.Next(1, 101);
            num3 = rnd.Next(1, 101);
            num4 = rnd.Next(1, 101);


            Pirate Luffy = new Pirate("Luffy", num);
            Pirate Zoro = new Pirate("Zoro ", num2);
            Pirate Usopp = new Pirate("Usopp", num3);
            //Pirate Nami = new Pirate("Nami", new Random().Next(1, 101));
            Pirate Sanji = new Pirate("Sanji", num4);

            PirateGang Shp = new PirateGang();
            PirateGang ph = new PirateGang();

            Shp.setName("Straw Hat Pirates");
            Shp.addPirate(Luffy);
            Shp.addPirate(Usopp);

            ph.setName("Pirate Hunters");
            ph.addPirate(Zoro);
            ph.addPirate(Sanji);

            //Shp.setLeader(Luffy);
            //Shp.addPirate(Usopp);
            //Shp.addPirate(Nami);
            //Shp.addPirate(Sanji);
            //Shp.addPirate(blind);

            //Console.WriteLine("Leader : "+Shp.getLeader().getName());

            Shp.printPiratesDetails();
            ph.printPiratesDetails();

            // print pick
            Console.WriteLine();
            Console.WriteLine(Shp.getName());
            Console.WriteLine(Shp.pickPirate().getName() + " " +Shp.pickPirate().getHealth());
            Console.WriteLine();
            Console.WriteLine(ph.getName());
            Console.WriteLine(ph.pickPirate().getName()+" "+ph.pickPirate().getHealth());
            Console.WriteLine();
            Console.WriteLine("Battle Start!!!");
            Shp.pickPirate().fight(ph.pickPirate());

            //Sanji.fight(Luffy);
        }
    }
}
