using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp
{
    class TowerOfHanoi
    {
        void tower(int a, char from, char aux, char to)
        {
            if (a == 1)
            {
                Console.WriteLine($"\t\tMove disc 1 from { from } to { to }\n");
                return;
            }
            else
            {
                tower(a - 1, from, to, aux);
                Console.WriteLine($"\t\tMove disc {a} from { from } to { to }\n");
                tower(a - 1, aux, from, to);
            }
        }

        //public static void Main(string[] args)
        //{
        //    TowerOfHanoi t = new TowerOfHanoi();
        //    t.tower(5,'a','b','c');
        //}
    }
}
