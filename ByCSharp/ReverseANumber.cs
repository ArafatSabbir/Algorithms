using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    class ReverseANumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number To Reverse");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{num} reverse by Mod is {ReverseByMod(num)}");
        }

        static int ReverseByMod(int num)
        {
            int rem;
            int reverse = 0;
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            return reverse;
        }


    }
}
