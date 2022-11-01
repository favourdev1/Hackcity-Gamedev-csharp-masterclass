using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Assignment
 {
   public class Program
   {
     public static void Main(string[] args)
     {

//Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation

        Console.WriteLine(takeVal());
       
       
       Console.Read();
     }
     
     
       
       
     
     public static string takeVal(){
       Console.WriteLine("Please emter a value:" );
       string value = Console.ReadLine();
      
      double num = Double.Parse(value);
      
       string[] unit = {"Zero", "One", "Two", "Three",  
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",  
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",  
    "Seventeen", "Eighteen", "Nineteen" };
    
   string [] ty = {"","","Twenty", "Thirty" , "Fourty","Fifty", "Sixty","Seventy","Eighty","Ninety"};
    
    
     int counter =0;
       
       
       
       try{
        // string value = num.ToString();
         
      int intNum;
       
       if (num <20){
        intNum = (int)num;
        
         return unit[(int)num];
       }
       
       
       
       
       
       if(num<100 ){
        
        intNum = int.Parse(value[0].ToString());
         
         
         if(int.Parse(value[1].ToString()) == 0){
           return ty[intNum];
         
         }else{
           return ty[intNum]+ unit[int.Parse(value[1].ToString())];
         
       }
       
       }
       
       
       
       
       
       
       
       if (num>99 & num<=999){
       intNum =int.Parse(value[0].ToString());
      if(int.Parse(value[1].ToString()) == 0){
           return unit[intNum] + " hundred";
         
         }else{
           if(value[2] =='0'){
             return unit[intNum] + " hundred and " + ty[int.Parse(value[1].ToString())];
           }else{
             
             return unit[intNum] + " hundred and " + ty[int.Parse(value[1].ToString())]+" " + unit[int.Parse(value[2].ToString())];
             
             
             
           }
           
         
       }
       }
       
       }catch(Exception){
        return  "error";
       }
       return "";
     }
     
   }
 }
 
 
 
 
 
 
 
 
 
 
 
