using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class MenuCalc
   {
     public static void Main(string[] args)
     {
       
       Console.WriteLine("This program is our simple caculator");
       Selector ();
     }
     
     
     public static void Selector(){
       Console.WriteLine("Please enter an operation to be performed");
       
       Console.WriteLine("1. Addition");
       Console.WriteLine("2. Substraction");
       Console.WriteLine("3. Divison");
       Console.WriteLine("4. Multiplication");
       Controller();
       
     }
     
     public static void Controller(){
       int selection=0;
      bool isInt = int.TryParse(Console.ReadLine(),out selection);
       if(!isInt || selection <0 || selection>5){
         
         Console.WriteLine("Please enter a valid input");
         Controller();
       }
       
       Console.WriteLine("Please enter the value for x and y to be calculated \n");
           Console.Write("x: ");
           double x =Double.Parse( Console.ReadLine());
          Console.Write("y: ");
           double y = Double.Parse( Console.ReadLine());
          
       switch(selection){
         case 1:
            Console.WriteLine(x + "+" + y + " = " + Addition(x,y));
          
           break;
           
           case 2: 
           Console.WriteLine(x + " - " + y + " = " + Subtraction(x,y));
           break;
           
         case 3: 
           Console.WriteLine(x + " / " + y + " = " + Division(x,y));
           break;
           
           case 4: 
           Console.WriteLine(x + " x " + y + " = " + Multiplication(x,y));
           break;
     
     
           
       }
       
       
       
     }
      
     
     
     
     public static double Subtraction (double num1, double num2){
       return num1-num2;
       }
     public static  double Addition (double num1, double num2){            
       return num1 + num2;
     } 
     
     
     public static  double Division (double num1, double num2){            
       return num1 / num2;
     }  
     public static  double Multiplication (double num1, double num2){            
       return num1 * num2;
     }  
     
     
   }
 }

