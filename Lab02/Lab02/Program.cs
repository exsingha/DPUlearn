using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student dit = new Student();
            dit.setName("dit");
            Student sow = new Student();
            sow.setName("sow");
            Student obama = new Student();
            obama.setName("obama");

            Teacher t1 = new Teacher();
            t1.setName("Aj.Ohm");

            //Course c1 = new Course();
            //c1.setCoursename("OOP");
            //c1.setCourseID("CE216");
            //c1.setTeacher("Aj.Ohm");



            Course std1 = new Course();

            std1.setCoursename("OOP");
            std1.setCourseID("CE216");
            std1.setTeacher("Aj.Ohm");

            std1.register("dit");
            std1.register("sow");
            std1.register("obama");

            std1.printStudent();
            std1.printTeacher();
        }
    }
}
