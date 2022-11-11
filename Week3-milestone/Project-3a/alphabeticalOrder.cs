using System;
using System.Linq;
using System.Collections.Generic;




namespace StringToArray
{
   public static class Program
   {
	  public static void Main()
	  {
		 string text = "h o w re yo u";
		 //	Write a program that reads a list of words, separated by spaces 
		 //and prints the list in an alphabetical order.
		 alphabeticalOrder(text);
	  }


	  public static void alphabeticalOrder(string input)
	  {

		 //takes value and convert the input 
		 //to an array using a space delimiter 

		 string[] arr = input.Split(" ");
		 var myList = new List<string>();
		 //adds the value at index of string[] to our list so it can be sorted
		 foreach (var val in arr)
		 {
			myList.Add(val);

		 }

		 myList.Sort();
		 foreach (var n in myList)
		 {
			Console.WriteLine(n);
		 }
	  }


   }
}
