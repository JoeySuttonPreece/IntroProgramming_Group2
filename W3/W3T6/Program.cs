/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 14/03/2019
 * Time: 5:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3T6
{
	class Program
	{
		public static int GetNum() {
			int num = 0;
			
			while (!Int32.TryParse(Console.ReadLine(), out num)) {
				Console.WriteLine("Please enter a number!");
			}
			
			return num;
		}
		
		public static void Main(string[] args)
		{
			int counter = 0;
			
			Random rand = new Random();
			
			int num = rand.Next(1, 1000);
			
			Console.WriteLine("Dont tell anyone but the big spooky random number is " + num);
			
			Console.WriteLine("Can you guess the big spooky secret number??????!??!!???!1?/?");
			
			while (counter < 10) {
				if (GetNum() == num) {
					Console.WriteLine("Correct");
				} else {
					Console.WriteLine("Wrong, counter value is " + counter);
				}
				
				counter += 1;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}