public class Solution {
    public string FreqAlphabets(string s) {
        StringBuilder st = new StringBuilder();
        int num;
        
        for(int i=0; i < s.Length; i++)
        {
            num = (s[i]-'0');
            
            if (i+2 < s.Length && s[i+2] =='#')
            {
                num = num * 10 +(s[i+1]-'0');
                i+=2;
            }
          
            st.Append((char)('a'+num-1));
        }
        
        return st.ToString();
    }
}
