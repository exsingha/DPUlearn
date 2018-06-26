using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Student
    {
        private string id;
        private string name;
        private string surname;
        private double GPA;

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
        public void setGPA(double GPA)
        {
            this.GPA = GPA;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string surName()
        {
            return surname;
        }
        public double getGPA()
        {
            return GPA;
        }
        public void printDetails()
        {

        }
    }
}
