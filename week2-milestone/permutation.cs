using System;
using System.Linq;
using System.Collections.Specialized;

namespace Permutationcalc
{
   public static class Program
   {
	  public static void Main()
	  {
		 Console.WriteLine("This program gets the permutation of any value that is entered. ");
		 Console.Write("Please enter a number: ");
int value =0;
		 bool isNumber = int.TryParse(Console.ReadLine(), out value);

		 if (isNumber)
		 {

			int permutationValue = GeneratePermutation(value);
			Console.WriteLine(value + "! = " + permutationValue);
			Console.WriteLine("\nThe values are .... \n");
			printPermutations(permutationValue,value);

		 }else{
		 	Console.WriteLine("invalid entry. Please enter a number");
		 }

	  }

	  public static int GeneratePermutation(int input)
	  {
		 if (input >= 1)
		 {
			return input * GeneratePermutation(input - 1);
		 }
		 return 1;
	  }


	  public static void printPermutations(int permutation, int n)
	  {
		 int num = 0;
		 int[] count = new int[n];
		 while (num < n)
		 {

			count[num] = num + 1;
			num++;

		 }


		 //Console.WriteLine(count);
		 string[] arr = new string[permutation];
		 int innerCounter = permutation;


		 int arrLength = arr.Length;
		 // string shuffledValue = "";
		 for (int i = 0; i < permutation; i++)
		 {

			arr[i] = checkPermutation(ShuffelArr(count), arr, count);
		 }
		 foreach (var val in arr)
		 {
			Console.WriteLine(val);
		 }


	  }

	  public static string checkPermutation(string shuffledValue, string[] arr, int[] count)
	  {

		 // Use Array.Exists in different ways.
		 bool a = Array.Exists(arr, element => element == shuffledValue);


		 if (!a)
		 {
			return shuffledValue;
		 }
		 return checkPermutation(ShuffelArr(count), arr, count);
	  }







	  public static string ShuffelArr(int[] count)
	  {
		 string result = "";
		 var rng = new Random();
		 var shuffledArray = count.OrderBy(e => rng.NextDouble()).ToArray();
		 foreach (var arr in shuffledArray)
		 {
			result = result + arr;
		 }
		 return result;

	  }
   }


}

