using System;

 namespace Helloworld
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      // Write an expression that checks if a given integer is odd or even.
      Console.WriteLine("This program check if the value entered is even or odd \n");
      Console.WriteLine("please enter a number");
      int num = Convert.ToInt32(Console.ReadLine());
      if(num%2 == 0){
        Console.WriteLine("even");
      }else{
        Console.WriteLine("odd");
      }
      
      Console.ReadLine();
       
      }
     
     
   }
 }
   
