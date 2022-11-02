using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       
       //Write a program to convert binary numbers to their decimal representation.
       Console.Write("Please enter a number : ");
    convert2Binary();
    }
    
    public static void  convert2Binary(){
      
      
    
      int value;
      
      
       bool isNum= int.TryParse(Console.ReadLine(), out value);
      if (isNum){
        int counter = 0;
        int divResult =value;
        string tempResult ="";
        while (divResult>2){
         tempResult =tempResult + divResult%2;
          divResult =divResult/2;
          
          
        }
        
        Console.WriteLine(reverseString(tempResult));
      }else{
        Console.WriteLine("Value entered is not a number, please ensure to enter a number");
     convert2Binary();
      }
     }
     
     public static string reverseString(string value){
       string result ="";
       for (int i =value.Length-1; i>=0; i--){
         result =result +  value[i].ToString();
       }
       return result;
     }
   }
 }

