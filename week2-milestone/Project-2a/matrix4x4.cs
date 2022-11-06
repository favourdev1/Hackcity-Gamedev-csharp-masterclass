 using System;
using System.Linq;
using System.Collections.Generic;

namespace Matrix
{
   public static class Program
   {
	  public static void Main()
	  {
	  	
	  //	Write a program that fills a matrix of size (N, N)
	  //and show same in the console (for N=4):
	  	
	  	Console.WriteLine("This program prints 4x4 matrix \n Please fill in the values for the matrix");
	  	
		 int counter, counter2 = 0;
		 string[,] arr = new string[4, 4];
		 string value = "";
		 for (int i = 0; i < 4; i++)
		 {
			for (int j = 0; j < 4; j++)
			{
			   counter = i + 1;
			   counter2 = j + 1;
			   Console.Write("x" + counter + "," + counter2 + " : ");
			   value = Console.ReadLine();

			   counter++;
			   arr[i, j] = value;
			}
			Console.WriteLine();
		 }
		 Console.WriteLine("\n \n Here is your 4x4 matrix");

		 Console.WriteLine();
		 for (int i = 0; i < 4; i++)
		 {
			for (int j = 0; j < 4; j++)
			{

			   Console.Write("\t" + arr[i, j] + "\t");



			}

			Console.WriteLine();
		 }


	  }
   }
}
