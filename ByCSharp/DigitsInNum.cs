using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    public static class DigitsInNum
    {
        public static void DisitsInNumer(int num)
        {
            if (num == 0) return;
            int disit = num % 10;
            DisitsInNumer(num / 10);
            Console.Write($"{disit} ");
        }


    }
}
