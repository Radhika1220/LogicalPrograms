using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class FibSeries
    {
        public static void GenerateFibSeries()
        {
            Console.WriteLine("Enter a number to generate fibonnaci series");
            int fib=Utility.ReadInput();
            int fib1 = 0, fib2 = 1, sum = 0;
            Console.Write(fib1 + " " + fib2);
            for(int i=2;i<fib;i++)
            {
                sum = fib1 + fib2;
                Console.Write(" " + sum);
                fib1 = fib2;
                fib2 = sum;
            }
        }
    }
}
