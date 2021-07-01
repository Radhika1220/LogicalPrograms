using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// P8-Print the day of week for a given date
    /// </summary>
    class dayOfWeek
    {
        public static void GetInput()
        {
            List<string> myList = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter the date :");
            int d = Utility.ReadInput();
            Console.WriteLine("Enter the month :");
            int m = Utility.ReadInput();
            Console.WriteLine("Enter the year :");
            int y = Utility.ReadInput();
            Date(d, m, y);
        }
        private static void Date(int d,int m,int y)
        {

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("Day is :"+d0);
        } 
    }
}
