public class Solution {
    public int[] SumZero(int n)
        {
            int[] myArr = new int[n];
            int half = n / 2;

            if (n % 2 == 0)
            {
                for (int i = 0; i <= n/2; i++)
                {
                    myArr[i] = -1 * (half+1);
                    myArr[n-i-1] = half+1;
                    half--;
                }
            }
            else
            {
                myArr[half] = 0;
                for (int i = 0; i <= n/2; i++)
                {
                    myArr[i] = -1 * half;
                    myArr[n - i-1] = half;
                    half--;
                }
            }

            return myArr;

        }
}
