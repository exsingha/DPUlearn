using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumPrice = 0;
            Product[] p = new Product[5];
            p[0] = new TV(3600,"Sharp",29);
            p[1] = new TV(12000, "Samsung", 32);
            p[2] = new MP3Player(4500, "Apple", "pink");
            p[3] = new Book(300, "Se-ed", 2010);
            p[4] = new Book(120, "DPU", 2012);

            //Console.WriteLine("No.\tClass\tregularPrice\tManufacturer/publisher\tsize/color/year");
            //Console.WriteLine("-----------------------------------------------------------------------");

            for(int i = 0; i < p.Length; i++)
            {
                //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", i, "", p[i].getRegularPrice(),p[i].GetType);

                sumPrice += p[i].getRegularPrice();
            }
            Console.WriteLine("Sum Regular Price : {0}",sumPrice);

            sumPrice = 0;

            for(int i = 0; i < p.Length; i++)
            {
                sumPrice += p[i].computeSalePrice();
            }
            Console.WriteLine("Sum Sale Price : {0}", sumPrice);

        }
    }
}
