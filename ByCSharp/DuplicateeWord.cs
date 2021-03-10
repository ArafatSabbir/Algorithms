using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class DuplicateeWord
    {
        public static bool DuplicateWordCheck(string str)
        {
            string[] words = str.Split(' ');
            var hs = new HashSet<string>(words);
            if (words.Length == hs.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
