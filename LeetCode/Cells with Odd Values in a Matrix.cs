// Runtime: 92 ms, faster than 84.85% of C# online submissions for Cells with Odd Values in a Matrix.
// Memory Usage: 25 MB, less than 80.30% of C# online submissions for Cells with Odd Values in a Matrix.



public class Solution
{
    public int OddCells(int n, int m, int[][] indices)
    {
        int[] rows = new int[n];
        int[] cols = new int[m];

        foreach (var idxs in indices)
        {
            rows[idxs[0]]++;
            cols[idxs[1]]++;
        }

        int res = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if ((rows[i] + cols[j]) % 2 == 1)
                {
                    res++;
                }
            }
        }
        return res;
    }
}
