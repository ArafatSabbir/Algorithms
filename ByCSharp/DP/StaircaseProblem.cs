using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp.DP
{
    class StaircaseProblem
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int t = Int32.Parse(Console.ReadLine());
        //        for (int i = 0; i < t; i++)
        //        {
        //            var o = new StaircaseProblem();
        //            int n = Int32.Parse(Console.ReadLine());
        //            Console.WriteLine(o.Stair(n));
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }

        //}


        int Stair(int n)
        {
            long [] dp = new long[100001];
            for (int i=0;i< 100001; i++)
            {
                dp[i] = -1;
            }

            if (n <= 2)
            {
                return n;
            }
            if (n == 3)
            {
                return 4;
            }

            if (dp[n] != -1)
            {
                Convert.ToInt32(dp[n]);
            }

            int m = 1000000007;
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= 100001; i++)
            {
                dp[i] = (dp[i - 3] + dp[i - 2] + dp[i - 1]) % m;
            }


            return Convert.ToInt32(dp[n]);
        }



        /// recursion
        /// 
        //int Stair(int n)
        //{
        //    if (n==1 || n==2 )
        //    {
        //        return n;
        //    }
        //    if ( n == 3)
        //    {
        //        return 4;
        //    }

        //    int res = 0;
        //    res += Stair(n - 1);
        //    res += Stair(n - 2);
        //    res += Stair(n - 3);

        //    return res;
        //}
    }
}
