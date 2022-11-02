using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace ConvertHexToDec
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine( "This program converts a given value from hexadecimal to int" );
      Console.Write("Please enter a number in hexadecimal: ");
      string input = Console.ReadLine();
       int result = (int)Convert.ToInt32(input,16);
       Console.WriteLine(result);
       Console.Read();
     }
   }
 }

