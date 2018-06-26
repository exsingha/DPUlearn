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
        public static VendingMachine coke = new VendingMachine();
        public static VendingMachine water = new VendingMachine();
        public static VendingMachine greentea = new VendingMachine();

        static void Main(string[] args)
        {
            try
            {
                //string path = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/chapter8.txt";
                //string newpath = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/chapter8copy.txt";
                string coke_path = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/coke.txt";
                string water_path = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/water.txt";
                string greentea_path = "C:/Users/DPU/source/repos/DPUlearn/Lab08_01/greentea.txt";

                int num = 0;
                int num2 = 0;

                //writeFile(path);
                //readFile(path);
                //copyFile(path,newpath);



                coke.SetPrice(15);
                coke.SetSize(100);

                water.SetPrice(10);
                water.SetSize(100);

                greentea.SetPrice(12);
                greentea.SetSize(100);

                Console.WriteLine(":: Choose type ::");
                Console.WriteLine("1. Coke \t 2. Water \t 3. Green Tea");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Size is ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1: coke.SetSize(num2); break;
                    case 2: water.SetSize(num2); break;
                    case 3: greentea.SetSize(num2); break;
                    default: Console.WriteLine("Error"); break;
                }
                writeFile(coke_path, coke);
                writeFile(water_path, water);
                writeFile(greentea_path, greentea);

                readFile(coke_path);
                readFile(water_path);
                readFile(greentea_path);

                Console.WriteLine();
            }
            catch (IOException)
            {
                Console.WriteLine("Error");
            }

        }
        static void writeFile(string filename, VendingMachine vm)
        {
            StreamWriter sw = new StreamWriter(filename, false, Encoding.Unicode);

            sw.WriteLine(vm.GetPrice());
            sw.WriteLine(vm.GetSize());

            sw.Close();
        }
        static void writeFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, false, Encoding.Unicode);
            
            //sw.WriteLine("DIT");
            //sw.WriteLine("Yu");
            //sw.WriteLine("PED");

            sw.Close();
        }

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
            StreamWriter sw = new StreamWriter(destination, false, Encoding.Unicode);
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
