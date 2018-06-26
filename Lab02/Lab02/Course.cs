using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Course
    {
        private string courseID;
        private string coursename;
        private string teacher;
        private string[] students = new string[50];
        private int student_count = 0;

        public void setCoursename(string cname)
        {
            coursename = cname;
        }
        public void setCourseID(string cid)
        {
            courseID = cid;
        }
        public void setTeacher(string teachername)
        {
            teacher = teachername;
        }
        public void register(string studentname)
        {
            students[student_count] = studentname;
            student_count++;
        }
        public void printTeacher()
        {
            Console.WriteLine("Teacher : "+teacher);
        }
        public void printStudent()
        {
            Console.WriteLine("Students : ");
            for(int i = 0; i < student_count; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
