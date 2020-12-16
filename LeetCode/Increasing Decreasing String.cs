// Runtime: 76 ms, faster than 100.00% of C# online submissions for Increasing Decreasing String.
// Memory Usage: 25.2 MB, less than 98.97% of C# online submissions for Increasing Decreasing String.




public class Solution {
    public string SortString(string s) {
        int[] counts = new int[26];
            foreach (var c in s)
            {
                counts[c - 'a']++;
            }

            StringBuilder sb = new StringBuilder(s.Length);
            int direction = 1;
            int idx = 0;

            while (sb.Length != s.Length)
            {
                if (idx == 26 || idx == -1)
                {
                    direction = -direction;
                    idx += direction;
                }

                if (counts[idx] > 0)
                {
                    counts[idx]--;
                    sb.Append((char) (idx + 'a'));
                }

                idx += direction;
            }

            return sb.ToString();
        
    }
}