using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    class iStudent : InterStudent
    {
        private string school;
        private double grade;

        public void setSchool(string school)
        {
            this.school = school;
        }
        public void setGrade(double grade)
        {
            this.grade = grade;
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
