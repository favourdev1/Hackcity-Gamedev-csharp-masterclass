using System;
using System.Linq;
using System.IO;
namespace File_Reader
{
   public static class Program
   {
	  public static void Main()
	  {

		 string filePath = "test.txt";
		 if (File.Exists(filePath))
		 {
			string[] txt1 = File.ReadAllLines(filePath);

			foreach (var f in txt1)
			{
			   Console.WriteLine(f.Replace("start", "finish"));

			}
		 }
		 else
		 {
			Console.WriteLine("this file does not exist");
		 }

		 Console.ReadKey();

	  }
   }
}
