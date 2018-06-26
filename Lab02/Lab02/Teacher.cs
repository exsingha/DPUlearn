using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Teacher
    {
        private string id;
        private string name;
        private string surname;

        public void setID(string id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public void printDetails()
        {

        }
    }
}
