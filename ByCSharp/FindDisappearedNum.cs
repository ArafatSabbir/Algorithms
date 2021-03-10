using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    class FindDisappearedNum
    {
        public IList<int> FindDisappearedNumbersd(int[] nums)
        {
            

            var set = new HashSet<int>(nums);
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(i + 1))
                {

                }
                else
                {
                    result.Add(i + 1);
                }
            }

            return result;

        }

        public IList<int> FindDisappearedNumbersd2(int[] nums)
        {
            return Enumerable.Range(1, nums.Length).Except(nums.Distinct()).ToList();
        }
    }
}
