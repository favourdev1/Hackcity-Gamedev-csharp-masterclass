using System;

 namespace Helloworld
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      // Write a boolean expression that checks for a given integer if it can be divided (without remainder) by 7 and 5 at the same time.
      Console.WriteLine("This program check if a given integer can be divided (without remainder) by 7 and 5 at the same time. \n");
      Console.WriteLine("please enter a number");
      int num = Convert.ToInt32(Console.ReadLine());
      if(num%7 == 0 && num%5==0){
        Console.WriteLine(true);
      }else{
        Console.WriteLine(false);
      }
      
      Console.ReadLine();
       
      }
     
     
   }
 }
   
