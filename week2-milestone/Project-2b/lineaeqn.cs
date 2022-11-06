using System;
using System.Linq;

namespace Lineareqn
{
   public static class Program
   {

	  public static int a = 1;
	  public static int b = 1;

	  public static void Main()
	  {
		 Console.WriteLine("This program solves a linear equation of the form Ax + b = 0");
		 Console.WriteLine("Plese Provide the following values");
		 Console.Write("A: ");

		 bool checkA = int.TryParse(Console.ReadLine(), out a);
		 if (!checkA)
		 {
			Console.WriteLine("Invalid input entered  ");

		 }
		 else
		 {
			if (a == 0)
			{
			   Console.Write("Value for a can not be 0");

			}
			else
			{
			   Console.Write("B: ");
			   bool checkB = int.TryParse(Console.ReadLine(), out b);
			   if (!checkB)
			   {
				  Console.WriteLine("Invalid input entered or a can not be =0");

			   }
			   else
			   {
				  Console.WriteLine("result = " + Solution());
			   }
			}
		 }


	  }


	  public static float Solution()
	  {
		 
		 return (float) -(b)/a;

	  }


   }
}
