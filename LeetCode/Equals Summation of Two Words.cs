// Runtime: 68 ms, faster than 96.77% of C# online submissions for Check if Word Equals Summation of Two Words.
// Memory Usage: 22.7 MB, less than 100.00% of C# online submissions for Check if Word Equals Summation of Two Words.


public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        if ((StoInt(firstWord) + StoInt(secondWord)) == StoInt(targetWord))
            return true;
        else
            return false;
    }
    
    
    int StoInt(string s) {
        int res = 0;
        for (int i = 0; i < s.Length; i++) {
            res *= 10;
            res += (s[i] - 'a');
        }
        return res;
    }
    
}
