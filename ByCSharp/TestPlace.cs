using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ByCSharp
{
    public class TestPlace
    {
        public static void Main(string[] args)
        {
            int[] nums = {3, 2, 4, 5, 8, 9, 10};
            Console.WriteLine(ConsecutiveTriplets.TripletsCount(nums));

    }

    }
}
