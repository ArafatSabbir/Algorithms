
using System;
using static System.Console;

namespace ByCSharp
{


    class Solution
    {


        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if(v2>=v1 && x1!=x2)           //all test case passed
            {
                return "NO";
       
            }
            else
            {
                 float x = (float)(x2-x1)/(v1-v2);

                if( floor(x) == x )
                     return "YES";
                 else
                    return "NO";
       
        }
            
            
            /*if (x2 > x1 && v2 > v1)
            {
                return "NO";
            }
            else
            {
                int result = (x1 - x2) % (v2 - v1);
                if (result == 0)
                {
                    return "YES";
                }
                else
                {
                    return "NO";

                }

            }*/


        }



        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            WriteLine(result);
        }
    }


}
