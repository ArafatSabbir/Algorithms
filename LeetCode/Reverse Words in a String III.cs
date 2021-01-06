// using linq

public class Solution {
    public string ReverseWords(string s) {
        return string.Join(" ",s.Split(' ').Select(str => new String(str.Reverse().ToArray())));
    }
}

// String builder

public class Solution {
    public string ReverseWords(string s) {
        string[] split = s.Split(" ");
		StringBuilder sb = new StringBuilder();
		foreach (string w in split){
			char[] arr = w.ToCharArray();
			Array.Reverse(arr);
			sb.Append(new string(arr));
			sb.Append(" ");
		}

		return sb.ToString().Trim();
    }
}
