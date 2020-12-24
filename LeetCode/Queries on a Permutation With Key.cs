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
