using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class TV : Electronics
    {
        private int size;
        public TV(double regularPrice, string manufacturer
            , int size
            ) : base(regularPrice, manufacturer)
        {
            this.size = size;
        }
        public override double computeSalePrice()
        {
            return base.getRegularPrice() * 0.8;
        }

    }
}
