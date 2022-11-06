using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Alphabet
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Write a program that creates an array containing all letters from the alphabet (A-Z). 
       //Read a word from the console and print the index of each of its letters in the array.
       char start ='A';
       char end = 'Z';
       
       while(start<=end ){
         Console.WriteLine(start);
         start ++;
       }
       
       Console.ReadLine();
       
     }
   }
 }
