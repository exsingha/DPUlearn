using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Customer
    {
        private string firstName;
        private string lastName;
        
        BankAccount account = new BankAccount();

        public Customer(string firstin, string lastin)
        {
            firstName = firstin;
            lastName = lastin;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setAccount(BankAccount accountin)
        {
            account = accountin;
        }
        public BankAccount getAccount()
        {
            return account;
        }
    }
    
}
