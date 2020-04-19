import java.util.Scanner;

public class Solution {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int n = in.nextInt();
        int t = in.nextInt();
        int[] width = new int[n];
        for (int i = 0; i < width.length; i++) {
            width[i] = in.nextInt();
        }
        for (int tc = 0; tc < t; tc++) {
            int i = in.nextInt();
            int j = in.nextInt();
            System.out.println(min(width, i, j));
        }

        in.close();
    }

    static int min(int[] a, int start, int end) {
        int result = Integer.MAX_VALUE;
        for (int i = start; i <= end; i++) {
            result = Math.min(result, a[i]);
        }
        return result;
    }
}
