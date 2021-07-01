using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// P4-Reversing a number
    /// </summary>
    class ReverseNum
    {
        //private static int rev;

        public static void FindingRevNum()
        {
            Console.WriteLine("Enter a number to reverse");
            int num=Utility.ReadInput();
            int rem, rev = 0;
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
        
            Console.WriteLine("Reversed Number is : {0} ",rev);

        }
    }
}
