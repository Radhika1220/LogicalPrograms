using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// P7-To return the minimal number of notes for amount
    /// </summary>
    class VendingMachine
    {
        public static void GenerateNotes()
        {
            Console.WriteLine("Enter the amount to return change");
            int amount=Utility.ReadInput();
            MinimalNotes(amount);
        }
        private static void MinimalNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count = new int[notes.Length];
            for(int i=0;i<notes.Length;i++)
            {
                if(amount>=notes[i])
                {
                    count[i] = amount / notes[i];
                    amount = amount - (count[i] * notes[i]);
                    if(amount<0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Currency count....");
            for(int a=0;a<notes.Length;a++)
            {
                if(count[a]!=0)
                {
                    Console.WriteLine(notes[a] + "--->" + count[a]);
                }
            }
        }
    }
}
