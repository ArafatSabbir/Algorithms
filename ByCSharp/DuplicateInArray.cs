using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ByCSharp
{
    class DuplicateInArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i])-1;
                if (nums[index] < 0)
                {
                    res.Add(index+1);
                }

                nums[index] = -nums[index];
            }

            return res;

        }

        public IList<int> FindDuplicates2(int[] nums)
        {
            var set = new HashSet<int>();
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (set.Contains(num))
                    result.Add(num);

                set.Add(num);
            }

            return result;
        }

    }
}
