// Runtime: 84 ms, faster than 96.76% of C# online submissions for Height Checker.
// Memory Usage: 24.8 MB, less than 43.36% of C# online submissions for Height Checker.



public class Solution {
    public int HeightChecker(int[] heights)
        {
            int[] heights2 = (int[])heights.Clone();
            Array.Sort(heights2);
            var count = 0;
            for (var i = 0; i < heights.Length; i++)
            {
                if (heights[i] != heights2[i])
                    count++;
            }

            return count;
        }
}
