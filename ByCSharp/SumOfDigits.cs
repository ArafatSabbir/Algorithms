using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sumOfDisit(n));
        }

        static int sumOfDisit(int num)
        {
            int sum = 0, dupnum = num, reminder = 0;

            while (num != 0)
            {
                reminder = num % 10;
                num = num / 10;
                sum = sum + reminder;
            }

            return sum;
        }
    }
}
