using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp.String
{
    class LongestPalindromeInString
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
                return s;
            if (s.Length == 2)
            {
                if (s[0] != s[1])
                {
                    return s[0].ToString();
                }
                else
                {
                    return s;
                }
            }


            string res = "";
            int MaxPl = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - i - 1; j < s.Length - i - 1; j--)
                {
                    string test = s.Substring(i, j);
                    if (IsPalindrome(test))
                    {
                        if (test.Length >= MaxPl)
                        {
                            res = test;
                        }
                    }
                }

            }
            return res;
        }

        bool IsPalindrome(string p)
        {
            return p.SequenceEqual(p.Reverse());
        }
    }
}
