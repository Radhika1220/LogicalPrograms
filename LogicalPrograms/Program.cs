using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option !");
            Console.WriteLine("1.Fibonacci Series");
            Console.WriteLine("2.Perfect Number");
            Console.WriteLine("Select a option");
            switch(Console.ReadLine())
            {
                case "1":
                    FibSeries.GenerateFibSeries();
                    break;
                case "2":
                    PerfectNumber.FindPerfectNumber();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}
