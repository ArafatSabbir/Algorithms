public class Solution {
    public string DestCity(IList<IList<string>> paths) {            
        ISet<string> fromSet = new HashSet<string>();
        foreach (var p in paths)
        {
            fromSet.Add(p[0]);
        }

        foreach (var p in paths)
        {
            if (!fromSet.Contains(p[1]))
            {
                return p[1];
            }
        }

        return "";
    }
}
