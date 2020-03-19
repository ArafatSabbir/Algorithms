import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
    Scanner in = new Scanner(System.in);
    int i = in.nextInt();
    int j = in.nextInt();
    int k = in.nextInt();
    int numOfBeautifulDays=0;
    for(int l=i; l<=j;l++) {
       if((l-reverse(l))%k ==0)  numOfBeautifulDays++;
    }
    System.out.println(numOfBeautifulDays);
}

public static int reverse(int number){
    int reverse = 0;
    while(number!=0){
        reverse = 10*reverse +number%10;
        number = number/10;
    }
    reverse += number;
    return reverse;
}
}
