using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class BankAccount
    {
        private string id;
        private string owner;
        private double balance;
        public static readonly string bankName = "SCB";

        public BankAccount()
        {
            id = "";
            owner = "";
            balance = 0;
        }
        public BankAccount(string input1,string input2,double input3)
        {
            id = input1;
            owner = input2;
            balance = input3;
        }
        public void setID(string idin)
        {
            id = idin;
        }
        public void setOwner(string ownerin)
        {
            owner = ownerin;
        }
        public void setBalance(double balancein)
        {
            balance = balancein;
        }
        public string getID()
        {
            return id;
        }
        public string getOwner()
        {
            return owner;
        }
        public double getBalance()
        {
            return balance;
        }
        public void deposite(double money)
        {
            balance += money;
        }
        public void withdraw(double money)
        {
            balance -= money;
        }

    }
}
