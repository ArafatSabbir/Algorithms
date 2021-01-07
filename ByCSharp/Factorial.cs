using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n + " Factorial is : " + FactorialByLoop(n));
        }

        private static int FactorialByLoop(int num)
        {
            int fac = 1;
            
            for (int i = 1; i <= num; i++)
            {
                fac = fac * i;
            }

            return fac;
        }

    }
}
