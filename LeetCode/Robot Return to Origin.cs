public class Solution {
    public bool JudgeCircle(string moves) {
        return (moves.Count(x => x == 'L') == moves.Count(x => x == 'R')) && (moves.Count(x => x == 'D') == moves.Count(x => x == 'U'));
        
    }
}


// fast

public class Solution {
    public bool JudgeCircle(string moves) {
        int h = 0;
        int v = 0;
        char[] m = moves.ToCharArray();
        
        for(int i = 0; i < m.Length; i++)
        {
            switch (m[i])
            {
                case 'L':
                    h--;
                    break;
                case 'R':
                    h++;
                    break;
                case 'U':
                    v++;
                    break;
                case 'D':
                    v--;
                    break;
                default:
                    break;
            }
        }

        
        return (h == 0 && v == 0);
        
    }
}
