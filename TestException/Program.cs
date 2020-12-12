using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            try
            {
                Console.Write($"Enter Value: ");
                val = int.Parse(Console.ReadLine());
               
            }
            catch (ArgumentNullException argNull)
            {
                Console.WriteLine($"Exception Caught: {argNull.Message}");
                Console.WriteLine($" Writing value as zero");
                val = 0;
            }
            catch (FormatException feEx)
            {
                Console.WriteLine($"Exception Caught: {feEx.Message}");
                Console.WriteLine($" Writing value as zero");
                val = 0;
            }


            Console.WriteLine($"value: {val}");
            Console.ReadLine();
        }
    }
}
