using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMidterm
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice d1 = new Dice();
            Dice d2 = new Dice(5);

            int[] player1 = new int[3];
            int[] player2 = new int[3];

            Coin c = new Coin();

            int total1 = 0;
            int total2 = 0;

            d1.setValue();
            d1.setValue();
            d2.setValue();
            c.setCoin();

            player1[0] = d1.getValue();
            player1[1] = d2.getValue();
            player1[2] = c.getCoin();

            total1 = player1[0] + player1[1] + player1[2];

            Console.WriteLine("PLayer 1");
            Console.WriteLine("Dice 1 : " + player1[0]);
            Console.WriteLine("Dice 2 : " + player1[1]);
            Console.WriteLine("Coin   : " + player1[2]);
            Console.WriteLine("Total  : " + total1);

            d1.setValue();
            d2.setValue();
            d2.setValue();
            d2.setValue();
            c.setCoin();
            c.setCoin();

            player2[0] = d1.getValue();
            player2[1] = d2.getValue();
            player2[2] = c.getCoin();

            total2 = player2[0] + player2[1] + player2[2];

            Console.WriteLine("\nPLayer 2");
            Console.WriteLine("Dice 1 : " + player2[0]);
            Console.WriteLine("Dice 2 : " + player2[1]);
            Console.WriteLine("Coin   : " + player2[2]);
            Console.WriteLine("Total  : " + total2);
            Console.WriteLine();
            if (total1 > total2)
            {
                Console.WriteLine("Winner is Player1");
            }
            else if(total1 < total2)
            {
                Console.WriteLine("Winner is Player2");
            }
            else
            {
                Console.WriteLine("Tie");
            }
            Console.WriteLine();
        }
    }
}
