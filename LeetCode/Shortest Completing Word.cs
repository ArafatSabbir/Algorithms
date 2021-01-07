// Runtime: 112 ms, faster than 80.00% of C# online submissions for Shortest Completing Word.
// Memory Usage: 28.6 MB, less than 90.00% of C# online submissions for Shortest Completing Word.



public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) 
    {
        var result = "";
        var chars = new List<char>();
        
        foreach (char item in licensePlate.ToLower())
        {
            if ((int)item >= 97 && (int)item <= 122)
            {
                chars.Add(item);
            }
        }
        
        foreach (string item in words)
        {
            
            int counter = 0;
            string orgStr = item;
            string word = item.ToLower();
            for (int i = 0; i <= chars.Count - 1; i++)
            {
                    if(word.Contains(chars[i]))
                    {
                        word = word.Remove(word.IndexOf(chars[i]), 1);
                        counter++;
                    }
            }
            if(counter == chars.Count)
            {
            result = (string.IsNullOrEmpty(result)||result.Length > orgStr.Length) ? orgStr:result;
            }
        }
        return result;

    }
}
