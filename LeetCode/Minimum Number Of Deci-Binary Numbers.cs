public class Solution {
    public int MinPartitions(string n) {
        var ans = 0;
        var str = Convert.ToString(n);
        foreach (var ch in str)
        {
            int val = (int)Char.GetNumericValue(ch);
            if (ans < val)
                ans = val;
        }
        
        return ans;
        
    }
}
