public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0, n = mat.Length;
        
        for(int i = 0; i < n; i++)
        {
            sum += mat[i][i] + mat[i][n - 1 - i];
        }
        
        return n % 2 == 0? sum : sum - mat[n / 2][n / 2];
    }
}
