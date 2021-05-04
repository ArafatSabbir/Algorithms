using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class MajorityElement
    {
        public int majorityElement(int[] nums)
        {
            int n = nums.Length;
            Dictionary<int, int> count = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (count.ContainsKey(nums[i]))
                    count[nums[i]]++;
                else
                    count.Add(nums[i], 1);
                if (count[nums[i]] > n / 2) return nums[i];
            }
            return Int32.MaxValue;
        }
    }
}
