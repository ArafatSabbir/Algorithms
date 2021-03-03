using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class ClosestDessertCost
    {
        public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
        {
            bool[] dp = new bool[30000];
            dp[0] = true;
            foreach (var t in toppingCosts)
            {
                for (int i = 29999; i >= 0; i--)
                {
                    if (dp[i])
                    {
                        if (i + t < 30000) dp[i + t] = true;
                        if (i + 2 * t < 30000) dp[i + 2 * t] = true;
                    }
                }
            }
            int best = 99999999;
            foreach (var b in baseCosts)
            {
                for (int i = 0; i < 30000; i++)
                {
                    if (dp[i])
                    {
                        int v = b + i;
                        if (Math.Abs(v - target) < Math.Abs(best - target) ||
                            Math.Abs(v - target) == Math.Abs(best - target) && v < best
                        )
                        {
                            best = v;
                        }
                    }
                }
            }
            return best;
        }
	}
}
