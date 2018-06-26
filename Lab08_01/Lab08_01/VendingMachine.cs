using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_01
{
    class VendingMachine
    {
        private int coke_size;
        private int water_size;
        private int greeTea_size;
        private int size;
        private int price;
        private int money;

        public VendingMachine()
        {
            coke_size = 0;
            water_size = 0;
            greeTea_size = 0;
            size = 0;
            price = 0;
            money = 0;
        }
        public void SetSize(int size)
        {
            this.size = size;
        }

        public int GetSize()
        {
            return size;
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }

        public int GetPrice()
        {
            return price;
        }
        public int SellProduct(int money)
        {
            this.money = money;
            return money - price;
        }
    }
}
