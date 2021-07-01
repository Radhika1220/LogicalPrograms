using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// P9-Conversion of temperature
    /// </summary>
    class tempConversion
    {
        public static void GetInput()
        {
            Console.WriteLine("Enter the Celsius:");
            double cel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            tempConvert(cel, fahrenheit);
        }
        private static void tempConvert(double cel, double fahrenheit)

        {
            double celToFar = (cel * 9 / 5) + 32;
            double FarToCel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celusis To Fahrenheit Temperature : " + Math.Round(celToFar));
            Console.WriteLine("Fahrenheit To Celusis Temperature : " + Math.Round(FarToCel));
        }
    }
}
