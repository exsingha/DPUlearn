using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMidterm
{
    class Dice
    {
        Random rnd = new Random();
        private int num;

        public Dice()
        {
            num = 0;
        }
        public Dice(int value)
        {
            num = value;
        }
        public void setValue()
        {
            num = rnd.Next(1, 13);
        }
        public int getValue()
        {
            return num;
        }
    }
}
