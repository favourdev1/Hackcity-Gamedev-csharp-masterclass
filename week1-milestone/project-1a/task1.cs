using System;

 namespace Helloworld
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Create a Console Application to Print to the console A fictitious firm record. 
       //The record would have the following characteristics – 
       //Company name, Company Industry, Company Location, Company Mission, Company Vision and the Company CEO.
       string companyName = "Gatrice \n";
       string companyIndustry = "Marketing \n";
       string companyLocation = "101 Independence Avenue, S.E. Washington, D.C. 20-60 \n";
       string companyMission = "Delivering measurable results to clients, employees, and vendors \n";
      string companyVision = "Our vision is to create a business world full of prosperity, meaning, and connection for all.\n";
      string companyCEO = "Okechukwu Favour \n";
      


       Console.WriteLine(companyName);
       Console.WriteLine(companyIndustry);
       Console.WriteLine(companyLocation);
       Console.WriteLine(companyMission);
       Console.WriteLine(companyVision);
       Console.WriteLine(companyCEO);
       Console.ReadLine();
     } 
     
     
   }
 }
  
