public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        
        List<string> res = new List<string>();
        
        string p = GetPattern(pattern);        
        foreach(string word in words)
        {
            if(GetPattern(word) == p)
                res.Add(word);
        }
        
        return res;
    }
    
    private string GetPattern(string word)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        StringBuilder sb = new StringBuilder();
        
        foreach(char ch in word)
        {
            if(!map.ContainsKey(ch))
                map.Add(ch, map.Count);
            
            sb.Append(map[ch]);
        }
        
        return sb.ToString();
    }
}
