using System;

namespace LogicalPrograms
{
    class Program
    {
        private static int start;
        private static int end;

        public static int n { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option !");
            Console.WriteLine("1.Fibonacci Series");
            Console.WriteLine("2.Perfect Number");
            Console.WriteLine("3.Generate a prime numbers between range");
            Console.WriteLine("4.Reversing a number");
            Console.WriteLine("5.Coupon Number");
            Console.WriteLine("6.Stop Clock");
            Console.WriteLine("7.Vending Machine");
            Console.WriteLine("8.Day Of Week");
            Console.WriteLine("9.Temperature Conversion");
            Console.WriteLine("10.Monthly Payment");
            Console.WriteLine("11.Sqrt Function using newton's method");
            Console.WriteLine("12.Decimal To Binary Representation");
            Console.WriteLine("13.Swapping Nibbles");

            Console.WriteLine("Select a option");
            switch(Console.ReadLine())
            {
                case "1":
                    FibSeries.GenerateFibSeries();
                    break;
                case "2":
                    PerfectNumber.FindPerfectNumber();
                    break;
                case "3":
                    PrimeNum.FindingPrimeNum();
                    break;
                case "4":
                    ReverseNum.FindingRevNum();
                    break;
                case "5":
                    CouponNum.GenerateCouponNum();
                    break;
                case "6":
                    StopWatch.ElapsedTime();
                    break;
                case "7":
                    VendingMachine.GenerateNotes();
                    break;
                case "8":
                    dayOfWeek.GetInput();
                    break;
                case "9":
                    tempConversion.GetInput();
                    break;
                case "10":
                    monthlyPayment.GetInput();
                    break;
                case "11":
                    Sqrt.sqrtRoot();
                    break;
                case "12":
                    DecimalToBinary.binaryConversion();
                    break;
                case "13":
                    SwapNibbles.swapNibbles();
                    break;
                        

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}
