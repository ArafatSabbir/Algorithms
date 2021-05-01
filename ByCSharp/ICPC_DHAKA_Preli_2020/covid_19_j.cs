using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp.ICPC_DHAKA_Preli_2020
{
    class covid_19_j
    {
        public static void Main(string[] args)
        {
            int t = Console.Read();
            int result = 0;
            if (t < 6)
            {
                result = 1;
            }
            else
            {
                if (t % 6 == 0)
                {
                    result = (t / 6) + 1;
                }
                else
                {
                    result = (t / 6) + 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
