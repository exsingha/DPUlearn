using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlecture01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade = "";
            Console.WriteLine("input score");
            int score = Convert.ToInt32(Console.ReadLine());
            //int score =Console.Read();
            if (score >= 0 && score <= 49)
            {
                grade = "F";
            }
            else if (score >= 50 && score <= 59)
            {
                grade = "D";
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "C";
            }
            else if (score >= 70 && score <= 79)
            {
                grade = "B";

            }
            else if (score >= 80 && score <= 100)
            {
                grade = "A";

            }
            else { grade = "invalid"; }
            Console.WriteLine("Grade is "+grade);
        }
    }
}
