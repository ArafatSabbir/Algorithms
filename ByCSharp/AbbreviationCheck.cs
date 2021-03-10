using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class AbbreviationCheck
    {
        public static bool AbbrCheck(string str, string abr)
        {
            string s = "";
            string[] words = s.Split(' ');
            foreach (var w in words)
            {
                s += w[0];
            }

            if (s == abr)
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
