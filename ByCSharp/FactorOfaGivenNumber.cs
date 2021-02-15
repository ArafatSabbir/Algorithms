using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class FactorOfaGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number To find it's Factors");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num%i == 0)
                {
                    Console.WriteLine($"{i} is Factor of {num}");
                }
            }
        }



    }
}
