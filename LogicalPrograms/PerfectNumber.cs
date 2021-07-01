using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        /// <summary>
        /// //P2-To check whether the number is perfect  or not
        /// </summary>
        public static void FindPerfectNumber()
        {
            Console.WriteLine("Enter a number to find perfect number");
            int perfectNum=Utility.ReadInput();
            int sum = 0;
            for(int i=1;i<perfectNum;i++)
            {
                //Finding the divisors of number
                if(perfectNum%i==0)
                {
                    sum = sum + i;
                }
            }
            if(sum==perfectNum)
            {
                Console.WriteLine("{0} is a perfect number", perfectNum);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", perfectNum);
            }
        }
    }
}
