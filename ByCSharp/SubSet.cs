using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByCSharp
{
    class SubSet
    {
        //static void Main(string[] args)
        //{
        //    int[] nums = {1, 2, 3, 4, 5};
        //    var res = Subsets(nums);

        //    foreach (var i in res)
        //    {
        //        for (int j = 0;j<i.Count;j++)
        //        {
        //            Console.Write((i[j]));
        //        }

        //        Console.WriteLine();
        //    }

        //}

        public static IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var count = Math.Pow(2, nums.Length);

            for (int i = 0; i < count; i++)
            {
                var oneResult = new List<int>();
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i >> j & 1) == 1)
                    {
                        oneResult.Add(nums[j]);
                    }
                }

                result.Add(oneResult);
            }
            return result;
        }


    }
}
