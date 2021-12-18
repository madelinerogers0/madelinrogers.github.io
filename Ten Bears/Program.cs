using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ten_Bears
{
    class Program
    {
        static void Main(string[] args)
        {
            int bearsNeeded = 6;
            int bearTotal = 0;
            Console.WriteLine("A while loop. Total bears: " + bearTotal);
            while (bearTotal < bearsNeeded)
            {
                MakeBear();
                bearTotal++;
            }
            Console.WriteLine("A do while loop. Total bears: " + bearTotal);
            do
            {
                MakeBear();
                bearTotal++;
            } while (bearTotal < bearsNeeded);

            Console.WriteLine("A for loop.");
            int total = 2;
            for (int counter = 0; counter < total; counter++)
            {
                MakeBear();
            }

            Console.ReadLine();
        }
        static void MakeBear()
        {
            string bear = @"
                    {'' - '' }
                    ( .    .  )
                ,--  `   Y   '--.
                ````:         ; ''
                   /    ___   \
                 (    )'   `(   )
                ";
            Console.WriteLine(bear);
        }
    }
}
