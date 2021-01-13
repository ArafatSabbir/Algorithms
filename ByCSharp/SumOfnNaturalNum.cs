using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ByCSharp
{
    class SumOfnNaturalNum
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(SumOfNaturalNum(n));
        }

        static int SumOfNaturalNum(int number)
        {
            int sum = 0;
            sum = (number*(number + 1)) / 2;
            return sum;
        }
    }
}
