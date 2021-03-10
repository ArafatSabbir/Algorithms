using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    class TestPlace
    {
        static void Main(string[] args)
        {
            string s1 = "bdca";
            List<char> sw1 = s1.ToCharArray().ToList().Sort();
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
