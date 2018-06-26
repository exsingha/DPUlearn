using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class InterStudent : Student
    {
        public string country;

        public InterStudent()
        {
            country = "";
            Console.WriteLine("InterStudent: constructor InterStudent() is called");
        }
        public InterStudent(string _name, string _school, double _grade, string _country) : base(_name, _school, _grade)
        {
            name = _name;
            school = _school;
            grade = _grade;
            country = _country;
            Console.WriteLine("InterStudent: constructor InterStudent(string,string,double,string) is called");

        }
        public void setCountry(string _country)
        {
            country = _country;
        }
        public string getCountry()
        {
            return country;
        }
    }
}
