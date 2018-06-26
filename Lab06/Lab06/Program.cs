using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- create object Constructor InterStudent() ...");
            InterStudent interStudent1 = new InterStudent();

            Console.WriteLine("\n---- create object class Teacher ...");
            Teacher teacher1 = new Teacher();

            Console.WriteLine("\n---- create object from Constructor InterStudent(String, String, double, String)...");
            InterStudent interStudent2 =
                    new InterStudent("PSY", // Name
                    "Gangnam",              // Address
                    3.75,                   // Grade
                    "Korea");               // Country

            Console.WriteLine("=============================");
            Console.WriteLine("interStudent2.getName() = " + interStudent2.getName());

            Console.WriteLine("interStudent2.getAddress() = " + interStudent2.getAddress());

            Console.WriteLine("interStudent2.getSchool() = " + interStudent2.getSchool());

            Console.WriteLine("interStudent2.getGrade() = " + interStudent2.getGrade());

            Console.WriteLine("interStudent2.getCountry() = " + interStudent2.getCountry());

        }
    }
}
