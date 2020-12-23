// Runtime: 96 ms, faster than 80.70% of C# online submissions for Minimum Number of Steps to Make Two Strings Anagram.
// Memory Usage: 41.3 MB, less than 13.16% of C# online submissions for Minimum Number of Steps to Make Two Strings Anagram.


public class Solution {
    public int MinSteps(string s, string t) {
        int[] frqS = new int[26];
        foreach(char c in s)
        {
            frqS[c - 'a']++;
        }

        int[] frqT = new int[26];
        foreach(char c in t)
        {
            frqT[c - 'a']++;
        }

        int count = 0;
        for(int i = 0; i < 26; i++)
        {
            if(frqT[i] != frqS[i])
            {
                count += Math.Abs(frqT[i] - frqS[i]);
            }
        }

        return count / 2;
        
    }
}
