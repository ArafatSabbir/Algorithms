using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Fibonacci obj = new Fibonacci();
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum is : " + obj.FibSum(n));
        }

        int FibSum(int num)
        {
            if (num <= 1)
                return num;

            return FibSum(num - 1) + FibSum(num - 2);
        }
    }
}
