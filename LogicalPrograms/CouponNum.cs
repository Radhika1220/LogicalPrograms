
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CouponNum
{
    /// <summary>
    /// P5-Generate a distinct coupon number by using random function and count it. 
    /// </summary>
    public static void GenerateCouponNum()
    {
        Console.WriteLine("Enter start value");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end value");
        int end =Convert.ToInt32(Console.ReadLine());
        int num = end - start;
        int randomcount = 0;

        HashSet<int> mySet = new HashSet<int>();
   
        while (mySet.Count()< num + 1)
        {
            randomcount++;
            Random random = new Random();
            int r = random.Next(start, end + 1);
            mySet.Add(r);
           
        }
        foreach (int val in mySet)
        {
            Console.WriteLine(val + " ");
        }

        Console.WriteLine("Random Count : " + randomcount);
    }
}

      