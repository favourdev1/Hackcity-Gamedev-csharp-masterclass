using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// Compiler version 4.0, .NET Framework 4.5


namespace Bin2dec
{
   public class Program
   {
	  public static void Main(string[] args)
	  {
		 //Your code goes here
		 convert2Binary();
		 Console.ReadLine();
	  }

	  public static void convert2Binary()
	  {
		 Console.Write("please enter a number in binary : ");
		 int value = 0;


		 bool check = int.TryParse(Console.ReadLine(), out value);
		 string val = value.ToString();

		 double calculate = 0;
		 if (check)
		 {

			int count = 0;

			//Console.WriteLine(val);
			int count2 = val.Length;

			foreach (var c in val)
			{
			   
			   if (Int32.Parse(c.ToString()) != 0 && Int32.Parse(c.ToString()) != 1)
			   {

				  Console.WriteLine("Value entered is not in binary format");
				  //System.Environment.Exit(0);

				  break;

			   }
			   else
			   {
				  if (count == val.Length - 1)
				  {
					 count = 0;
					 while (count <= val.Length - 1)
					 {
						calculate += Int32.Parse(val[count2 - 1].ToString()) * Math.Pow(2, count);
						count++;
						count2--;
					 }
					 Console.WriteLine(calculate);

				  }
			   }
			   
			   count++;
			}


		 }
		 else
		 {
			Console.WriteLine("Incorrect input");
			convert2Binary();
		 }

	  }



   }
}
