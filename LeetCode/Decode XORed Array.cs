public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int n = encoded.Length;
        int[] arr = new int[n+1];
        arr[0] = first;
        
        for(int i=1;i<=n;i++)
        {
            arr[i] = arr[i-1] ^ encoded[i-1];
        }
        return arr;
    }
}
