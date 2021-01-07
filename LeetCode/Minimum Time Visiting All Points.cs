// Runtime: 124 ms, faster than 10.00% of C# online submissions for Minimum Time Visiting All Points.
// Memory Usage: 26.7 MB, less than 75.33% of C# online submissions for Minimum Time Visiting All Points.




public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int t = 0;
        for (int i = 1; i < points.Length; i++)
        {
            t += Math.Max(Math.Abs(points[i - 1][0] - points[i][0]), Math.Abs(points[i - 1][1] - points[i][1]));
        }
        return t;
        
    }
}
