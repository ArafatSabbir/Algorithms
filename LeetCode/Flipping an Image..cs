public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        
            if (A == null || A[0] == null)
                return new int[0][];

            int rows = A.Length;
            int columns = A[0].Length;

            for(int i = 0; i < rows; i++)
            {
                int start = 0;
                int end = columns - 1;
                while(start < end)
                {
                    var tmp = A[i][start];
                    A[i][start] = A[i][end];
                    A[i][end] = tmp;
                    start++;
                    end--;
                }

                for(int col = 0; col < columns; col++)
                {
                    A[i][col] ^= 1;
                }
            }

            return A;
    }
}
