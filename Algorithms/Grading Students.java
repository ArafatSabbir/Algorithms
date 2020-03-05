import java.io.*;
import java.util.*;


/*
	
	Sabbir Ahmed,Comilla University
	GitHub> https://github.com/ArafatSabbir
	
	*/


class Solution {
    public static void main(String[] args) {
      Scanner s = new Scanner(System.in);
      int length = s.nextInt();
      int [] mark = new int[length];
      

      for(int i=0; i<length; i++ ) {
         mark[i] = s.nextInt();
      }
      
      
      int [] newMark= new int[length];
      for(int i = 0; i< length; i++)
      {
          if(mark[i]<38)
          {
              newMark[i]=mark[i];
          }
          else if(mark[i]%5>2)
          {
              newMark[i]=(mark[i]/5)*5+5;
          }
          else
          {
              newMark[i]=mark[i];
          }

      }
      

        for(int i = 0; i< length; i++){

        System.out.println(newMark[i]);

        }
    
    }
}
