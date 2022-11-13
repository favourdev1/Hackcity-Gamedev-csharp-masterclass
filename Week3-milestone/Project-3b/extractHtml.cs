using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace StringToArray
{
   public static class Program
   {
	  public static void Main()
	  {



		 var script_rgx = new Regex(@"<script>/?[^>]+>");

		 var tag_rgx = new Regex(@"</?[^>]+>");


		 //input text/html
		 var txt = @"<html>

					<head><title>News</title>
					<script> console.log('hello world');
					</script></head>

					<body><p><a href='http://hackcity.io'>Hackcity</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body>

						</html>";

		 //remove js content from html
		 var replacedScriptTxt = script_rgx.Replace(txt, string.Empty);
 
		 //remove all remaining tags and trim the resulting string
		 var result = tag_rgx.Replace(replacedScriptTxt, string.Empty).Trim();
		 
		 
		 //optional to remove all extra tab spaces
		 result = removeTab(result);

		 Console.WriteLine(result);


	  }


	  public static string removeTab(string val)
	  {
		 return val.Replace("\t", "");
	  }



   }


}



