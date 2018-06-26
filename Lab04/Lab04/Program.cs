using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount Acct1 = new BankAccount();
            //BankAccount Acct2 = new BankAccount("2222225555", "phudit2", 1200);

            //Acct1.setID("1111115555");
            //Acct1.setOwner("phudit");
            //Acct1.setBalance(0);

            //Acct1.deposite(2000);
            //Acct1.withdraw(1500);

            //Acct2.deposite(1500);

            //Console.WriteLine("ID      : " + Acct1.getID());
            //Console.WriteLine("Owner   : " + Acct1.getOwner());
            //Console.WriteLine("Balance : " + Acct1.getBalance());
            //Console.WriteLine();

            //Console.WriteLine("ID      : " + Acct2.getID());
            //Console.WriteLine("Owner   : "+Acct2.getOwner());
            //Console.WriteLine("Balance : "+Acct2.getBalance());

            string name;
            string surname;
            string id;
            string inputid="";
            double money;
            double num;
            double num2;

            int input = 0;
            Customer man;
            BankAccount Acct3;

            Console.Write("Please enter name : ");
            name = Console.ReadLine();

            Console.Write("Please enter surname : ");
            surname = Console.ReadLine();

            Console.Write("Please enter ID : ");
            id = Console.ReadLine();

            Console.Write("Please enter money to create a bank account : ");
            money = Convert.ToDouble(Console.ReadLine());

            man = new Customer(name, surname);
            Acct3 = new BankAccount(id, man.getFirstName(), money);
            man.setAccount(Acct3);

            Console.WriteLine("\nName : " + man.getFirstName() + " " + man.getLastName() + " : open account with balance = " + man.getAccount().getBalance()+" baht");
            Console.WriteLine();

            while (input != 3)
            {
                Console.WriteLine("Please select menu 1: deposit 2: withdraw 3: exit");
                input = Convert.ToInt32(Console.ReadLine());

                if(input == 3)
                {
                    break;
                }

                do
                {
                    Console.Write("Please enter your ID : ");
                    inputid = Console.ReadLine();

                } while (inputid.Equals(man.getAccount().getID()) != true);

                if (input == 1)
                {
                    Console.Write("Please enter money to deposite : ");
                    num = Convert.ToDouble(Console.ReadLine());
                    Acct3.deposite(num);
                    Console.WriteLine("\nName : " + man.getFirstName() + " " + man.getLastName() + " : deposite " + num + " baht : current balance = " + man.getAccount().getBalance() + " baht");

                }
                else if(input == 2)
                {
                    Console.Write("Please enter money to withdraw : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Acct3.withdraw(num2);
                    Console.WriteLine("\nName : " + man.getFirstName() + " " + man.getLastName() + " : withdraw " + num2 + " baht : current balance = " + man.getAccount().getBalance() + " baht");

                }


                Console.WriteLine();
            }


            //do
            //{


            //    man = new Customer(name, surname);
            //    Acct3 = new BankAccount(id, man.getFirstName(), money);
            //    man.setAccount(Acct3);
            //    Console.WriteLine("\nName : " + man.getFirstName() + " " + man.getLastName()+ "open account with balance = " + man.getAccount().getBalance());

            //    Console.WriteLine("Please select menu 1: deposit 2: withdraw 3: exit");
            //    input = Convert.ToInt32(Console.ReadLine());

            //    if (input == 1)
            //    {
            //        continue;
            //    }
            //    else if (input == 2)
            //    {

            //    }

            //} while (input != 3);




            //Console.WriteLine("\nName : "+man.getFirstName()+" "+man.getLastName());
            //man.setAccount(Acct3);
            //Console.WriteLine("open account with balance = "+man.getAccount().getBalance());

        }
    }
}
