public class Solution {
    public string GenerateTheString(int n) {
        char[] res = new char[n];
        
        for(int i = 0; i < n; i++)
            res[i] = 'x';
        
        if((n & 1) == 0)
            res[0] = 'y';
        
        return new string(res, 0, res.Length);
    }
}
