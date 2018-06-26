using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture04
{
    class Dice
    {
        public int die;
        private Random rnd;

        public Dice()
        {
            rnd = new Random();
            roll();
        }
        public Dice(int val)
        {
            die = val;
        }
        public void roll()
        {
            die = rnd.Next(1, 7);
        }
    }
}
