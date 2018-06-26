using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Book : Product
    {
        private string publisher;
        private int yearPublished;

        public Book(double regularPrice, string publisher, int yearPublished) : base(regularPrice)
        {
            this.publisher = publisher;
            this.yearPublished = yearPublished;
        }
        public override double computeSalePrice()
        {
            return base.getRegularPrice() * 0.5;
        }
        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }
        public string getPublisher()
        {
            return publisher;
        }
        public void setYearPublished(int yearPublished)
        {
            this.yearPublished = yearPublished;
        }
        public int getYearPublished()
        {
            return yearPublished;
        }
    }
}
