import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int num = input.nextInt();
        
        double positive = 0;
        double negative = 0;
        double zero = 0;
        
        for(int i = 0; i<num; i++)
        {
            int value = input.nextInt();
            if (value>0){
                positive= positive+1;
            }
            else if (value<0){
                negative= negative+1;
            }
            else{zero=zero+1;}

        }

        System.out.println(positive/num);
        System.out.println(negative/num);
        System.out.println(zero/num);
    }
}
