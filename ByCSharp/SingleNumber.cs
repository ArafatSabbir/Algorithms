using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    class SingleNumber
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4, 3, 2, 4, 5, 1, 3, 1};
            Console.WriteLine(singleNumber(nums));
            
        }

        public static int singleNumber(int[] nums)
        {
            int n = 0;
            foreach (int num in nums)
            {
                n ^= num;
            }
            return n;
        }
    }
}
