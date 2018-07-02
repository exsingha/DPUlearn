using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prefinal01
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:/Users/DPU/source/repos/DPUlearn/Prefinal01/Data.txt";
            try
            {
                WriteFile(filename);
                ReadFile(filename);
            }
            catch (IOException)
            {
                Console.WriteLine("Error IOException");
            }
        }
        static void WriteFile(string _filename)
        {
            StreamWriter sw = new StreamWriter(_filename);
            sw.WriteLine("Phudit Kittimongkol");
            sw.Close();
        }
        static void ReadFile(string _filename)
        {
            string line = "";
            StreamReader sr = new StreamReader(_filename);
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.WriteLine();
        }
    }
}
