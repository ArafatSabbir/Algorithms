using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    public class CountItemMatchinARule
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;
            int rkval = 0;
            if (ruleKey == "type")
            {
                rkval = 0;
            }
            else if (ruleKey == "color")
            {
                rkval = 1;
            }
            else if (ruleKey == "name")
            {
                rkval = 2;
            }


            foreach (var item in items)
            {
                if (item[rkval] == ruleValue)
                {
                    count++;
                }
                
            }

            return count;
        }
    }
    
}
