public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var words = sentence.Split(' ').ToList();
        for(int i = 0; i < words.Count; i++)
            if(words[i].StartsWith(searchWord))
                return i + 1;
        return -1;
        
    }
}
