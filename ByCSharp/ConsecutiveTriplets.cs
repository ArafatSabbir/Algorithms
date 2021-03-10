using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class ConsecutiveTriplets
    {
        public static int TripletsCount(int[] nums)
        {
            int count = 0;
            Array.Sort(nums);
            for (int i = 0;i<nums.Length-2; i++)
            {
                if (nums[i] + 1 == nums[i+1] && nums[i + 1]+1 == nums[i+2])
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
