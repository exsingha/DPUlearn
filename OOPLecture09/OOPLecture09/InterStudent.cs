using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    public interface InterStudent
    {
        void setSchool(string school);
        void setGrade(double grade);
        string getSchool();
        double getGrade();
    }
}
