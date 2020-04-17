import java.io.*;
import java.util.*;


public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String s = in.next();
        int cs = 1;
        for (int i = 0; i < s.length(); i++) {
            String place = Character.toString(s.charAt(i));
            if (place == place.toUpperCase()) {
                cs++;
            }
        }
        System.out.println(cs);
    }
}
