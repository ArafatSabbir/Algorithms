using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    static class MinSub
    {
        public static int[] MinimumDistance(int n)
        {
            int[] xy = new int[2];
            int temp = (int)Math.Sqrt(n);
            for (int i = temp; i < n; i++)
            {
                if (n % i == 0)
                {
                    xy[0] = i;
                    xy[1] = n / xy[0];
                    break;
                }
            }
            return xy;
        }
    }
}
