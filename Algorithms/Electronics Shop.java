import java.io.*;
import java.util.*;

public class Solution {


    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int b = scanner.nextInt();
        int k = scanner.nextInt();
        int u = scanner.nextInt();

        int[] key = new int[k];
        int[] usb = new int[u];


        for(int i = 0;i<k;i++){
            key[i]= scanner.nextInt();
        }

        for(int j = 0;j<u;j++){
            usb[j]= scanner.nextInt();
        }

        Arrays.sort(key);
        Arrays.sort(usb);

        int max= -1;

        if(key[0]+usb[0]>b){
           System.out.println(max);
        }
        else{
            int fn =0;
            for (int i = 0; i < key.length; i++) {
                for (int j = 0; j < usb.length; j++) {
                    if (key[i] + usb[j] <= b && key[i] + usb[j] > max)
                        max = key[i] + usb[j];
                }
            }
            System.out.println(max);
        }



    }
}
