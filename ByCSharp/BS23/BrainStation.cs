using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ByCSharp.BS23
{
    class BrainStation
    {
        //public static void Main(string[] args)
        //{
        //    try
        //    {
        //        int t = Int32.Parse(Console.ReadLine());
        //        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        //        bs(arr);

        //    }
        //    catch (Exception)
        //    {
        //    }

            
        //}

        public static void bs(int[] arr)
        {
            //Array.Sort(arr);
            List<List<int>> li= new List<List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        List<int> tm = new List<int>();
                        if (((arr[i]<arr[j] && arr[j]%arr[i] ==0 )&& (arr[j]<arr[k] && arr[k]%arr[j] == 0)))
                        {
                            tm.Append(arr[i]);
                            tm.Append(arr[j]);
                            tm.Append(arr[k]);
                        }

                        if (tm.Count != 0)
                        {
                            li.Append(tm);
                        }

                    }
                }
                
            }

            if (li.Count == 0)
            {
                Console.WriteLine(-1);
            }

            else
            {
                foreach (var i in li)
                {
                    foreach (var si in i)
                    {
                        Console.WriteLine(si);
                    }
                }
            }


        }
    }
}
