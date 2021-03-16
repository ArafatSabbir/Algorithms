using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class RedundantWordsInStr
    {
        public IList<string> FindDuplicatesStr(string s)
        {
            string[] words = s.Split(' ');
            var set = new HashSet<string>();
            var result = new List<string>();

            foreach (var word in words)
            {
                if (set.Contains(word))
                {
                    result.Add(word);
                }
                set.Add(word);
            }
            return result;
        }
    }
}
