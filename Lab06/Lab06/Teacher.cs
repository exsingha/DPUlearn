using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Teacher : Person
    {
        public string subject;

        public Teacher()
        {
            subject = "";
            Console.WriteLine("Teacher: constructor Teacher() is called");

        }
        public Teacher(string _name, string _address, string _subject) : base(_name)
        {
            name = _name;
            address = _address;
            subject = _subject;
            Console.WriteLine("Teacher: constructor Teacher(string,string,string) is called");

        }
        public void setSubject(string _subject)
        {
            subject = _subject;
        }
        public string getSubject()
        {
            return subject;
        }
    }
}
