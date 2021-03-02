using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class BulbSwitcherIV
    {
        static bool allCharactersSame(string s)
        {
            int n = s.Length;
            for (int i = 1; i < n; i++)
                if (s[i] != s[0])
                    return false;

            return true;
        }

        public int MinFlips(string target)
        {
            int count = 0;

            if (allCharactersSame(target))
            {
                if (target[0] == '0')
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            for (int i = 1; i < target.Length; i++)
            {
                
                if (target[i - 1] != target[i])
                {
                    count++;
                } 

            }

            if (target[0] == '0')
            {
                return count - 1 ;
            }


            return count;

        }
    }
}
