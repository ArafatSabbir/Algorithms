using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year");
            int num = Int32.Parse(Console.ReadLine());
            if (IsLeapYear(num))
            {
                Console.WriteLine($"{num} is Leap Year");
            }
            else
            {
                Console.WriteLine($"{num} is not Leap Year");
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
