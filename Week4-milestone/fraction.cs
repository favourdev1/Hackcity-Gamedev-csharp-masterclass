using System;



namespace FractionExample
{
   public static class Program
   {
	  public static void Main()
	  {



		 FractionClass fraction = new FractionClass(FractionClass.Parse("20"), FractionClass.Parse("30"));


		 //3 decimal place
		 Console.WriteLine(fraction.DecimalValue(fraction.Solution()));


	  }
   }


   public class FractionClass
   {

	  public decimal Neumerator { get; set; }
	  private decimal Denominator { get; set; }

	  //constructor
	  public FractionClass(decimal neumerator, decimal denominator)
	  {
		 this.Neumerator = neumerator;
		 this.Denominator = denominator;
	  }

	  //converts to 3 dp
	  public decimal DecimalValue(decimal val)
	  {

		 return Math.Round(val, 4);
	  }


	  //converts input string to  decimal
	  public static decimal Parse(string val)
	  {
		 decimal result;
		 Decimal.TryParse(val, out result);
		 return result;
	  }


	  //provides solution for neumerator/denominator
	  public decimal Solution()
	  {
		 return this.Neumerator / this.Denominator;
	  }



   }
}
