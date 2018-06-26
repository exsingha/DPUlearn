using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i <= input; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
