using System;
using static System.Math;

namespace TriangleArea
{
   public static class Program
   {
	  public static void Main()
	  {
		 float tHeight, tBase, tLength;

		 float tAngle;
		 int option;
Console.WriteLine("AREA OF TRIANGLE");

Console.WriteLine();


		 Console.WriteLine("1. Area with a sides and height");
		 Console.WriteLine("2. Area with 3 sides");
		 Console.WriteLine("3. Area with 2 sides and an angle");
Console.WriteLine();

		 Console.Write("To calculate the area of triangle, Please Choose an option:  ");
		 

		 if (int.TryParse(Console.ReadLine(), out option) && !(option > 3) && !(option < 1))
		 {


Console.WriteLine();

			Console.Write(option != 2 ? "Height : " : "a : ");
			if (float.TryParse(Console.ReadLine(), out tHeight))
			{
			   Console.Write(option != 2 ? "Base : " : "b : ");
			   if (float.TryParse(Console.ReadLine(), out tBase))
			   {

				  if (option == 1)
				  {
					 Tryangle myTriangle = new Tryangle(tHeight, tBase);
					 Console.WriteLine("area of triangle is : " + myTriangle.calculate2Sides());

				  }

				  if (option == 2)
				  {
					 Console.Write("c : ");

					 if (float.TryParse(Console.ReadLine(), out tLength))
					 {


						Tryangle myTriangle = new Tryangle();
						myTriangle.setHeight(tHeight);
						myTriangle.setBase(tBase);
						myTriangle.setLength(tLength);


						Console.WriteLine("area of the triangle is : " + myTriangle.calculate3Sides());
					 }
					 else
					 {
						Console.WriteLine("Value entered was not a number");

					 }

				  }


				  if (option == 3)
				  {
					 Console.Write("Angle : ");
					 if (float.TryParse(Console.ReadLine(), out tAngle))
					 {


						Tryangle myTriangle = new Tryangle(tHeight, tBase, tAngle);
						Console.WriteLine("area of triangle is : " + myTriangle.calculate2SidesAngle());
					 }
					 else
					 {
						Console.WriteLine("Value entered was not a number");

					 }


				  }

			   }
			   else
			   {
				  Console.WriteLine("Value entered was not a number");
			   }

			}
			else
			{
			   Console.WriteLine("Value entered was not a number");
			}
		 }
		 else
		 {
			Console.WriteLine("Invalid input");
		 }


		 Console.ReadLine();
	  }


   }


}


public class Tryangle
{
   private float height, tBase, tLength;
   private float tAngle;


   /* ======== Constructor ======== */
   public Tryangle(float tHeight, float tBase, float tAngle)
   {
	  this.height = tHeight;
	  this.tBase = tBase;
	  this.tAngle = tAngle;
   }

   public Tryangle(float tHeight, float tBase)
   {
	  this.height = tHeight;
	  this.tBase = tBase;

   }


   public Tryangle()
   {


   }




   /* ========= getters  ==========*/
   public float getBase()
   {
	  return this.tBase;
   }

   public float getHeight()
   {
	  return this.height;
   }

   public float getLength()
   {
	  return this.tLength;
   }


   /* ======== setters  ======== */

   public void setLength(float tLength)
   {
	  this.tLength = tLength;
   }

   public void setHeight(float tHeight)
   {
	  this.height = tHeight;
   }


   public void setBase(float tBase)
   {
	  this.tBase = tBase;
   }



   /* ======= solutions ==========*/

   public float calculate2Sides()
   {
	  return (float)0.5 * this.height * this.tBase;
   }

   public double calculate2SidesAngle()
   {
	  return (double)0.5 * this.height * this.tBase * Sin(this.tAngle);
   }

   public double calculate3Sides()
   {
	  float cal1 = this.calculate2Sides() - this.tBase;
	  float cal2 = this.calculate2Sides() - this.height;
	  float cal3 = this.calculate2Sides() - this.tLength;
	  return Math.Sqrt(this.calculate2Sides() * (cal1 * cal2 * cal3));
   }


}



