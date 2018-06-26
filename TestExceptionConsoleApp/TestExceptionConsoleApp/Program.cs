using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestExceptionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(10 / x);
                Console.WriteLine("after divide");
                writeFile("C:/Users/DPU/source/repos/DPUlearn/TestExceptionConsoleApp/myoutput.txt");
                readFile("C:/Users/DPU/source/repos/DPUlearn/TestExceptionConsoleApp/myoutput.txt");
            }
            catch(IOException e)
            {

            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("divide by zero");

            }
            catch (Exception e)
            {
                Console.WriteLine("Not a number");
            }
            finally
            {
                Console.WriteLine("End of Program");
            }
          
        }
        static void readFile(string filename)
        {
            string line = "";
            StreamReader sr = new StreamReader(filename);
            //line = sr.ReadLine();
            //while(line != null)
            //{
            //    Console.WriteLine(line);
            //    line = sr.ReadLine();
            //}
            do
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            } while (line != null);

            sr.Close();
            Console.WriteLine();
        }
        //hello
        static void writeFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true,Encoding.Unicode);
            sw.WriteLine("Chanatip");
            sw.Close();
        }
    }
}
