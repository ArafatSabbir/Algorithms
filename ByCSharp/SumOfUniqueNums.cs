using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class SumOfUniqueNums
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = {1, 2, 2, 3, 4, 5};
            if (nums == null || nums.Length == 0)
                 sum = 0;

            int[] arr = new int[100];
            foreach (int num in nums)
            {
                arr[num - 1]++;
            }

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }



            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    sum += i + 1;
            }
            Console.WriteLine(sum);
        }
        public static int SumOfUnique(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;

            int[] arr = new int[100];
            foreach (int num in nums)
            {
                arr[num - 1]++;
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    sum += i + 1;
            }

            return sum;
        }
    }
}
