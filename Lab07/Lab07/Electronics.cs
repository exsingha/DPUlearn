using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Electronics : Product
    {
        private string manufacturer;
        public Electronics(double regularPrice, string manufacturer) : base(regularPrice)
        {
            this.manufacturer = manufacturer;
        }
        public override double computeSalePrice()
        {
            return base.getRegularPrice() * 0.6;
        }
        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public string getManufacturer()
        {
            return manufacturer;
        }

    }
}
