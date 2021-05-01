using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp.DP
{
    class StaircaseProblem
    {
        //static void Main(string[] args)
        //{
        //    int t = Int32.Parse(Console.ReadLine());
        //    for (int i = 0; i < t; i++)
        //    {
        //        var o = new StaircaseProblem();
        //        int n = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine(o.Stair(n));
        //    }

        //}

        int Stair(int n)
        {
            if (n==1 || n==2 )
            {
                return n;
            }
            if ( n == 3)
            {
                return 4;
            }

            int res = 0;

            res += Stair(n - 1);
            res += Stair(n - 2);
            res += Stair(n - 3);

            return res;
        }
    }
}
