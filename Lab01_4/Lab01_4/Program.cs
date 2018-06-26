using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int sum = 0;

            do
            {
                Console.Write("Please Enter a number : ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("Quit!");
                }
                else
                {
                    sum += input;
                    Console.WriteLine("Sum = "+sum);
                }
            } while (input!=0);
        }
    }
}
