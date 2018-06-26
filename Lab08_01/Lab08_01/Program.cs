using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab08_01
{
    class Program
    {

        static void Main(string[] args)
        {
            //string path = Directory.GetCurrentDirectory();
            try
            {
                string path = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/chapter8.txt";
                string newpath = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/chapter8copy.txt";
                writeFile(path);
                readFile(path);

                copyFile(path,newpath);
            }
            catch (IOException)
            {
                Console.WriteLine("Error");
            }
            //finally
            //{
            //    Console.WriteLine("Error other!");
            //}

        }
        static void writeFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true, Encoding.Unicode);
            sw.WriteLine("DIT");
            sw.WriteLine("Yu");
            sw.WriteLine("PED");
            sw.Close();
        }
        //static void writeFile(string filename,string line)
        //{
        //    StreamWriter sw = new StreamWriter(filename, true, Encoding.Unicode);
        //    do
        //    {
        //        sw.WriteLine(line);
        //    } while (line != null);
        //    sw.Close();
        //}
        static void readFile(string filename)
        {
            string line = "";
            StreamReader sr = new StreamReader(filename);

            do
            {

                Console.WriteLine(line);
                line = sr.ReadLine();

            } while (line != null);

            sr.Close();
        }
        static void copyFile(string source, string destination)
        {
            string line = "";
            StreamReader sr = new StreamReader(source);
            StreamWriter sw = new StreamWriter(destination, true, Encoding.Unicode);
            do
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
                sw.WriteLine(line);
            } while (line != null);
            
            sr.Close();
            sw.Close();
        }
    }
}
