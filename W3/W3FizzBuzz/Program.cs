/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 14/03/2019
 * Time: 5:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3FizzBuzz
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number = 1;
			
			while (number <= 100) {
				string fizz = number % 3 == 0 ? "Fizz" : "";
				string buzz = number % 5 == 0 ? "Buzz" : "";
				
				string final = "" + fizz + buzz;
				
				if (final  != "") {
					Console.WriteLine(final);
				} else {
					Console.WriteLine(number);
				}
				
				number += 1;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}