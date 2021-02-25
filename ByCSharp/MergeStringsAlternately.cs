using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            string result = "";
            int i = 0, j = 0;
            while (i < word1.Length || j < word2.Length)
            {

                if (i < word1.Length)
                    result = result + word1[i];

                if (j < word2.Length)
                    result = result + word2[j];

                i++;
                j++;
            }
            return result;
        }
    }
}
