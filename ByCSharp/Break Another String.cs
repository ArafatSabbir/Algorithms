using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    public class Break_Another_String
    {
        public bool CheckIfCanBreak(string s1, string s2)
        {
            string str1 = SortedString(s1), str2 = SortedString(s2);
            return CanBreak(str1, str2) || CanBreak(str2, str1);
        }

        private bool CanBreak(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] > s2[i])
                    return false;
            return true;
        }

        private string SortedString(string str)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
