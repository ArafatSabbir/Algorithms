public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
         var hset = new HashSet<string>();
        string[] morse = {".-","-...","-.-.","-..",".","..-.","--.",
                          "....","..",".---","-.-",".-..","--","-.",
                          "---",".--.","--.-",".-.","...","-","..-",
                          "...-",".--","-..-","-.--","--.."};
        var sb = new StringBuilder();
        foreach (string word in words) {
            foreach (char c in word) {
                sb.Append(morse[c-'a']);
            }
            hset.Add(sb.ToString());
            sb.Clear();
        }
        return hset.Count;
        
        
    }
}
