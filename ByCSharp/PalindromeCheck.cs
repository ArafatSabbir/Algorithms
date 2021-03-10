using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class PalindromeCheck
    {
        public static bool PalindromeCk(string str)
        {
            var st = new Stack<char>(str);
            var q = new Queue<char>(str);


            for (int i = 0; i < str.Length; i++)
            {
                char c1 = st.Pop();
                char c2 = q.Dequeue();
                if (c1 != c2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
