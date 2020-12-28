// Runtime: 68 ms, faster than 100.00% of C# online submissions for Determine if String Halves Are Alike.
// Memory Usage: 26.2 MB, less than 100.00% of C# online submissions for Determine if String Halves Are Alike.




public class Solution {
    public bool HalvesAreAlike(string s) {
        var vowels = new[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var left = 0;
        var right = 0;

        for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
        {
            if (vowels.Contains(s[i]))
            {
                left++;
            }

            if (vowels.Contains(s[j]))
            {
                right++;
            }
        }

        return left == right;
        
    }
}
