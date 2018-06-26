using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            double average = 0;
            int count = 0;
            int sum = 0;

            //Console.Write("input age : ");
            //input = Convert.ToInt32(Console.ReadLine());

            //while (input != 0)
            //{
                

            //}
            do
            {
                Console.Write("input age : ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    //break;
                }
                else
                {
                    sum += input;
                    count += 1; //นับจำนวนคน
                }
            } while (input != 0);
            average = sum / count;
            Console.WriteLine("Average age of student : "+average);
        }
    }
}
