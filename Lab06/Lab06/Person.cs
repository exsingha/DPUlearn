using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Person
    {
        public string name;
        public string address;

        public Person()
        {
            name = "";
            address = "";
            Console.WriteLine("Person: constructor Person() is called");
        }
        public Person(string _name)
        {
            name = _name;
            Console.WriteLine("Person: constructor Person(String) is called");
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public void setAddress(string _address)
        {
            address = _address;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
    }
    
}
