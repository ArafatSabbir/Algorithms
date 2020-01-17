import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the staircase function below.
    static void staircase(int n) {

    int space = n - 2;
    int c,k;

  for (k = 1; k <= n; k++)
  {
    for (c = 0; c <= space; c++)
      System.out.print(" ");

    space--;

    for (c = 0; c <= k-1; c++)
      System.out.print("#");

    System.out.print("\n");
  }

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        staircase(n);

        scanner.close();
    }
}
