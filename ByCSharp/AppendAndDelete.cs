using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace ByCSharp
{
    

    class Solution
    {
        
        

        static void Main(string[] args)
        {
            

            string s = ReadLine();

            string t = ReadLine();

            int k = Convert.ToInt32(ReadLine());

            int commonLength = 0;

            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                if (s.ElementAt(i) == t.ElementAt(i))
                    commonLength++;
                else
                    break;
            }
            //CASE A
            if ((s.Length + t.Length - 2 * commonLength) > k)
            {
                WriteLine("No");
            }
            //CASE B
            else if ((s.Length + t.Length - 2 * commonLength) % 2 == k % 2)
            {
                WriteLine("Yes");
            }
            //CASE C
            else if ((s.Length + t.Length - k) < 0)
            {
                WriteLine("Yes");
            }
            //CASE D
            else
            {
                WriteLine("No");
            }

        }
    }

}
