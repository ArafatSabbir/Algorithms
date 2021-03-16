using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class FibUningDP
    {
        public static int Fib(int n)
        {
            int[] seq = new int[n];
            seq[0] = seq[1] = 1;

            for (int i = 2; i < n; i++)
            {
                seq[i] = seq[i - 1] + seq[i - 2];
            }

            return seq[n - 1];
        }
    }
}
