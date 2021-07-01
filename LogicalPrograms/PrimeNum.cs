using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// P2-Generate the prime number between range
    /// </summary>
    class PrimeNum
    {
        public static void FindingPrimeNum()
        {
            Console.WriteLine("Enter a lower bound value");
            int low=Utility.ReadInput();
            Console.WriteLine("Enter a higher bound value");
            int high = Utility.ReadInput();

            for(int i=low;i<=high;i++)
            {
                int k = 2;
                int isPrime = 1;
                while(k<i)
                {
                    if(i%k==0)
                    {
                        isPrime = 0;
                    }
                    k++;
                }
                if(isPrime==1 && i!=1)
                {
                    Console.WriteLine("Number is prime:" + i);
                }
            }
        }
    }
}
