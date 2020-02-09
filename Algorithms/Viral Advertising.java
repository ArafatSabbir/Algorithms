import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
    
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        
        
        int reach = 2, share = 2;
        for(int i = 1; i < n; i++)
        {
            reach =reach + (share * 3) / 2;
            share = (share * 3) / 2;
        }
        System.out.println(reach);
    }
}
