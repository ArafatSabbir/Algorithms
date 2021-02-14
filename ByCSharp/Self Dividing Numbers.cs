using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    
    class Self_Dividing_Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SelfDividingNumbers(2,20));
        }


        public static bool IsSelfDivisible(int n)
        {
            foreach (char c in n.ToString())
                if (c == '0' || n % (c - '0') != 0)
                {
                    return false;
                }
            return true;
        }

        public static List<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; left <= right; i++)
                if (IsSelfDivisible(i))
                {
                    result.Add(i);
                }
            return result;
        }
    }

   
}
