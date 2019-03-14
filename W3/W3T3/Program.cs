/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 14/03/2019
 * Time: 4:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3T3
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
			while (true) {
				Console.WriteLine("Guess the magic number. It's somewhere between 1 and 10!!!");
				
				if (GetNum() == 5) {
					break;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}