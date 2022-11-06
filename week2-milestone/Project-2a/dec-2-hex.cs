using System;
using System.Linq;

namespace Hex2dec
{
   public static class Program
   {
	  public static void Main()
	  {
		 int inputNum =0;
		 int i = 1, j, temp = 0;
		 char[] hexadecimalNumber = new char[100];
		 char temp1;
		 Console.WriteLine("Enter a Decimal Number :");
		 inputNum = int.Parse(Console.ReadLine());
		 
		 while (inputNum != 0)
		 {
			temp = inputNum % 16;
			if (temp < 10)
			   temp = temp + 48;
			else
			   temp = temp + 55;
			temp1 = Convert.ToChar(temp);
			hexadecimalNumber[i++] = temp1;
			inputNum = inputNum / 16;
		 }
		 Console.Write("Equivalent HexaDecimal Number is ");
		 for (j = i - 1; j > 0; j--)
			Console.Write(hexadecimalNumber[j]);
		 Console.Read();
	  }
   }
}
