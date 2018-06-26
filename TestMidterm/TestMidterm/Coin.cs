using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMidterm
{
    class Coin
    {
        Random rnd = new Random();
        private int num;
        private int point;

        public Coin()
        {
            num = 0;
            point = 0;
        }
        public void setCoin()
        {
            num = rnd.Next(0, 2);
            if (num == 0) // หัว
            {
                point = 4;
            }
            else // ก้อย
            {
                point = 2;
            }
        }
        public int getCoin()
        {
            return point;
        }
    }
}
