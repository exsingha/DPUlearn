using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture02_1
{
    class Product
    {
        private string name;
        private int itemInStock;
        private string[] stockName = new string[20];
        private int nameCount = 0;

        private int price;

        public Product()
        {
            name = "";
            itemInStock = 0;
            price = 20;
        }

        public int Price
        {
            set
            {
                if (value <= 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
            get
            {
                return price;
            }
        }

        public void setName(string name)
        {
            this.name = name;
            stockName[nameCount] = this.name;
            nameCount++;
        }
        public string getName()
        {
            return name;
        }
        public void printAll()
        {
            for(int i = 0; i < stockName.Length; i++)
            {
                Console.WriteLine(stockName[i]);
            }
        }
        public void addItemInStock(int plus)
        {
            itemInStock += plus;
        }
        public void removeItemInStock(int plus)
        {
            itemInStock -= plus;
        }
        public int getItemInStock()
        {
            return itemInStock;
        }
    }
}
