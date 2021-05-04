using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp.BS23
{
    class BoardGames
    {
        //public static void Main(string[] args)
        //{
        //    int t = Int32.Parse(Console.ReadLine());
        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        //    boardGames(t, arr);
        //}

        public static void boardGames(int n, int[] arr)
        {

            int i, num0 = 0, num5 = 0;
            for (i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    num0++;
                }
                else
                {
                    num5++;
                }
            }

            num5 = (num5 / 9) * 9;

            if (num0 == 0)
            {
                Console.Write(-1);
            }

            else if (num5 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (i = 0; i < num5; i++)
                {
                    Console.Write(5);
                }
                for (i = 0; i < num0; i++)
                {
                    Console.Write(0);
                }
            }
        }

    }
}
