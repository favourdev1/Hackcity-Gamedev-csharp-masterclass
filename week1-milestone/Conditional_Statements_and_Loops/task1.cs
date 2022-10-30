using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// Compiler version 4.0, .NET Framework 4.5


namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args) {
            
//Write a program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.


Console.Write(takeVal());


            Console.Read();
        }





        public static string takeVal() {
            Console.Write("Please enter a value:");
            string value = Console.ReadLine();
            double num;


            try {
                num = Double.Parse(value);
            }catch(Exception) {
                return "please ensure to only enter a number";
            }


            string[] unit = {
                "Zero",
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine",
                "Ten",
                "Eleven",
                "Twelve",
                "Thirteen",
                "Fourteen",
                "Fifteen",
                "Sixteen",
                "Seventeen",
                "Eighteen",
                "Nineteen"
            };




            switch (num < 20) {
                case (false):
                    return "please enter a value between 0 and 19";

                    //
                    //  takeVal();
                    default:
                        return unit [(int)num];
                    }
                    return "";
            }

        }
    }
