using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Product
    {
        private double regularPrice;
        public Product(double regularPrice)
        {
            this.regularPrice = regularPrice;
        }
        public virtual double computeSalePrice()
        {
            return 0;
        }
        public void setRegularPrice(double regularPrice)
        {
            this.regularPrice = regularPrice;
        }
        public double getRegularPrice()
        {
            return regularPrice;
        }
    }
}
