//Runtime: 116 ms, faster than 100.00% of C# online submissions for Count the Number of Consistent Strings.
//Memory Usage: 37.4 MB, less than 100.00% of C# online submissions for Count the Number of Consistent Strings.


public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        bool[] valid = new bool[26];

        foreach(char c in allowed)
        {
            valid[c - 'a'] = true;
        }

        int count = 0;
        foreach(var word in words)
        {
           bool isValid = true;
           foreach(char c in word)
           {
               if(!valid[c - 'a'])
               {
                   isValid = false;
                   break;
               }
           }

           if(isValid)
           {
               count++;
           }
        }

        return count;
        
    }
}
