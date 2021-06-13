// point inside circle rule => (x - center_x)^2 + (y - center_y)^2 <= radius^2.(with boundery)


public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int[] res = new int[queries.Length];
        
        for(int i = 0; i<queries.Length;i++){
            res[i] = 0;
            for(int p = 0; p < points.Length; p++){
                if(( Math.Pow((points[p][0]-queries[i][0]), 2) + Math.Pow((points[p][1]-queries[i][1]), 2)) <= Math.Pow(queries[i][2], 2)){
                    res[i]++;
                }
            }  
        }  
        return res;
    }
}
