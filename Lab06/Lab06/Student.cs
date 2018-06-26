using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Student : Person
    {
        public string school;
        public double grade;

        public Student()
        {
            school = "";
            grade = 0;
            Console.WriteLine("Student: constructor Student() is called");
        }
        public Student(string _name, string _school, double _grade) : base(_name)
        {
            name = _name;
            school = _school;
            grade = _grade;
            Console.WriteLine("Student: constructor Student(string,string,double) is called");

        }
        public void setSchool(string _school)
        {
            school = _school;
        }
        public void setGrade(double _grade)
        {
            grade = _grade;
        }
        public string getSchool()
        {
            return school;
        }
        public double getGrade()
        {
            return grade;
        }
    }
}
