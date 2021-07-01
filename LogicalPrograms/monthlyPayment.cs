using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// 
    /// P10Calculate Monthly Payment 
    /// </summary>
    class monthlyPayment
    {
        public static void GetInput()
        {
            Console.WriteLine("Enter a principal");
            double principal = Utility.ReadInput();
            Console.WriteLine("Enter a interest amount ");
            double rate = Utility.ReadInput();
            Console.WriteLine("Enter a year");
            double year = Utility.ReadInput();
            calculateMonthlyPayment(principal, rate, year);
                
        }

        private static void calculateMonthlyPayment(double principal, double rate, double year)
        {
            double r = Math.Round(1 + (rate / 1200), 4);
            double n = 12 * year;
            double monthlyPayment = principal * (Math.Pow(r, n)) - principal;
            Console.WriteLine("Monthly payment " + Math.Round(monthlyPayment));

        }
    }
}
