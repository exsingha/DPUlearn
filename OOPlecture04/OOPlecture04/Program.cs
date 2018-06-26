using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture04
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum1 = 0;
            int sum2 = 0;

            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            Dice dice3 = new Dice();
            Dice dice4 = new Dice();

            do
            {
                dice1.roll();
                dice3.roll();
                dice3.roll();
                dice3.roll();

                sum1 = dice1.die + dice3.die;

                Console.WriteLine("First Dice  : " + dice1.die + " Second Dice : " + dice3.die + " total1 : " + sum1);

                dice2.roll();
                dice2.roll();
                dice4.roll();
                dice4.roll();
                dice4.roll();
                dice4.roll();

                sum2 = dice2.die + dice4.die;

                Console.WriteLine("First Dice  : " + dice2.die + " Second Dice : " + dice4.die + " total1 : " + sum2);

                
                count++;

                if (sum1 != sum2)
                {
                    Console.WriteLine("total1 = total2 --> false");
                }
                else
                {
                    Console.WriteLine("total1 = total2 --> true");
                }
                Console.WriteLine();
            } while(sum1 != sum2);

            Console.WriteLine("count : "+count+"\n");
        }
    }
}
