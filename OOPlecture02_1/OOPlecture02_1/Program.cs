using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product shirt = new Product();
            shirt.setName("Japan Shirt");
            shirt.addItemInStock(10);
            //shirt.Price = -50;
            Console.WriteLine(shirt.getName() + "\t" + shirt.getItemInStock());

            Product shirt2 = new Product();
            shirt2.setName("Mexico Shirt");
            shirt2.addItemInStock(20);
            //shirt2.Price = 100;
            Console.WriteLine(shirt2.getName() + "\t" + shirt2.getItemInStock());

            List<Product> list = new List<Product>();
            list.Add(shirt);
            list.Add(shirt2);

            Console.WriteLine();

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i+"="+list[i].getName()+" "+list[i].getItemInStock()+" "+list[i].Price);
            }

            Console.WriteLine("\nNAME" + "\t\t" + "STOCK" + "\t" + "PRICE");
            Console.WriteLine("-------------------------------");
            foreach (Product p in list)
            {
                Console.WriteLine(p.getName() +"\t"+ p.getItemInStock() + "\t" + p.Price);
            }
            Console.WriteLine();
            //list.Add(k);

            //shirt.removeItemInStock(5);
            //Console.WriteLine(shirt.getName() + "\t" + shirt.getItemInStock());

            //shirt.printAll();
        }
    }
}
