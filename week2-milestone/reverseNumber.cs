using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Example
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Write a program that can solve these tasks:
       //  Reverses the digits of a number
       
       
       Console.WriteLine(reverseString());
       
       
     }
     
     public static string reverseString(){
       Console.WriteLine("This program reverses a number");
       Console.WriteLine("Please enter a number");
       string val = Console.ReadLine().ToString();
       string result ="";
       int i = val.Length-1;
       
       while(i>=0){
         result =result + val[i];
         i--;
       }
       
       
       return "reverse of " + val + " is:" + result;
       
     }
   }
 }

