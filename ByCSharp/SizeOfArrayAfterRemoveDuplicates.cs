using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class SizeOfArrayAfterRemoveDuplicates
    {
        public int AfterDuplicateRemove(int[] nums)
        {
            var set = new HashSet<int>(nums);
            return set.Count;
        }
    }
}
