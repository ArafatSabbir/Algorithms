// Runtime: 240 ms, faster than 69.23% of C# online submissions for Queries on a Permutation With Key.
// Memory Usage: 31.2 MB, less than 69.23% of C# online submissions for Queries on a Permutation With Key.

public class Solution {
    public int[] ProcessQueries(int[] q, int m)
    {
            int[] res = new int[q.Length];
            var pLi = new List<int>();

            for (int i = 0; i < m; i++)
            {
                pLi.Add(i + 1);
            }

            int idx = 0;
             
            foreach (var x in q)
            {
                var p = pLi.IndexOf(x);
                res[idx++] = p;
                pLi.RemoveAt(p);
                pLi.Insert(0, x);
            }

            return res;
     }
        
}


/// v2
// Runtime: 236 ms, faster than 84.62% of C# online submissions for Queries on a Permutation With Key.
// Memory Usage: 31.2 MB, less than 38.46% of C# online submissions for Queries on a Permutation With Key.

public class Solution {
   public int[] ProcessQueries(int[] q, int m)
        {
            int len = q.Length;
            List<int> fnList = new List<int>();

            List<int> li = new List<int>();
            for (int i = 1; i <= m; i++)
                li.Add(i);

            foreach (var i in q)
            {
                int ind = li.IndexOf(i);
                fnList.Add(ind);
                li.RemoveAt(ind);
                li.Insert(0, i);

            }

            return fnList.ToArray();
        }
        
}

