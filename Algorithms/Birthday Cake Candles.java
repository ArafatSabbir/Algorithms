import java.io.*;
import java.util.*;


  /*
	
	Sabbir Ahmed,Comilla University
	GitHub> https://github.com/ArafatSabbir
	
	*/



public class Solution {

    public static void main(String[] args) {
       Scanner s = new Scanner(System.in);
      int length = s.nextInt();                       //take year as array size.
      int [] candNum = new int[length];               //new year size array 

      for(int i=0; i<length; i++ ) {
         candNum[i] = s.nextInt();
      }
      
      Arrays.sort(candNum);                         //sort for get arr[0] as max
      
      int [] res=new int[length];
      
      int i=0;
     
     while(i!=length)
     {
         res[length-1-i]=candNum[i];
         ++i;
     }
     
     int tall= res[0];
     int count=0;
     int j=0;
     
     while(j!=length)
     {
         if(tall==res[j]){                               // count if arr[i]==max
         ++count;
         }
         ++j;
     }
    System.out.println(count);
    
    }
}
