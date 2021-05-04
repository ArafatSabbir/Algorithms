using System;
using System.Collections.Generic;
using System.Text;
using ByCSharp.Input_Processing;

namespace ByCSharp.DP
{
    class SquareSubmatricescs
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int count = CountSquares(TakeUserInput.Input2dArray());
        //        Console.WriteLine(count);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        public static int CountSquares(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return 0;
            }

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int count = 0;
            int[] dp = new int[n + 1];

            int tmp = 0;

            for (int i = 1; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (matrix[i - 1,j - 1] == 1)
                    {
                        int curMin = Math.Min(Math.Min(dp[j - 1], dp[j]), tmp) + 1;
                        tmp = dp[j];
                        count += (dp[j] = curMin);
                    }
                    else
                    {
                        dp[j] = tmp = 0;
                    }
                }
            }

            return count;
        }

    }
}
