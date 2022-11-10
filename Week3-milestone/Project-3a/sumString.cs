using System;
using System.Linq;

namespace StringToArray
{
   public static class Program
   {
	  public static void Main(){
	  	sumString("43 68 9 23 318" );
	  }
	  
	  
	  public static void sumString(string input){
	  	
	  //takes value and convert the input 
	  //to an array using a space delimiter 
	  
		 string[] arr = input.Split(" ");
		 double result = 0, prevResult = 0;

		 foreach (var n in arr)
		 {
		 	//checks if thr value at the position of 
		 	//array can be converted to double
			if (double.TryParse(n, out prevResult))
			{
				
				
			   result += prevResult;
			}

		 }
		 Console.WriteLine("result = " + result);
	  }


   }
}
