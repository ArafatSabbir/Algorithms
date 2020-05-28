using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace ByCSharp
{
    

    class Solution
    {
         static int[] permutationEquation(int[] p)
         {
            int len = p.Length;
            int numHold = 0;
            int[] result = new int[len];
            for (int i = 1; i <= len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (p[j] == i) 
                    {
                        numHold = j + 1; 
                        break; 
                    }
                }
                for (int j = 0; j < len; j++)
                {
                    if (p[j] == numHold) 
                    { 
                        numHold = j + 1; 
                        break; 
                    }
                }
                result[i - 1] = numHold;

            }
            return result;
        }

            static void Main(string[] args)
            {
                
                int n = Convert.ToInt32(ReadLine());

                int[] p = Array.ConvertAll(ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
                int[] result = permutationEquation(p);

                WriteLine(string.Join("\n", result));


            }
    }

}
