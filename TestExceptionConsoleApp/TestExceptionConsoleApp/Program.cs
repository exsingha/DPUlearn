using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
