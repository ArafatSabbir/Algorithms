import java.util.Scanner;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        long sum = 0;
        long min = 2147483647;
        long max = 0;
        long tmp = 0;

        for (int i = 0; i < 5; i++) {
            tmp  = in.nextInt();
            max  = tmp > max ? tmp : max;
            min  = tmp < min ? tmp : min;
            sum += tmp;
        }

        // System.out.println("Max: " + max + "\nMin: " + min);
        System.out.println((sum - max) + " " + (sum - min));
        in.close();
    }
}
