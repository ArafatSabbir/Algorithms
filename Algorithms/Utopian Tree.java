import java.io.*;
import java.util.*;
;

public class Solution {

   public static void main(String[] args) {

    int height,n;

    Scanner in = new Scanner(System.in);

    int t = in.nextInt();

    for(int a0 = 0; a0 < t; a0++){

    n = in.nextInt();

    height=1;

    for(int i=0;i<n;i++){

    if (i%2 == 0) height*=2;

    else height++;

    }

    System.out.println(height);

    }

    in.close();

    }
}
