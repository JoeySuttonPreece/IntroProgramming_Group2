/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 21/03/2019
 * Time: 3:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W4
{
	class Program
	{
		public static void Main(string[] args)
		{
//			T1_1();
			T1_2();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int GetNum() {
			int num = 0;
			
			while (!Int32.TryParse(Console.ReadLine(), out num)) {
				Console.WriteLine("Please enter a number!");
			}
			
			return num;
		}
		
		public static void T1_1() 
		{
			string input = Console.ReadLine();
			
			string output = "";
			
			int counter = 0;
			
			while (counter < 10) {
				output += input;
				counter++;
			}
			
			counter = 0;
			
			while (counter < 10) {
				Console.WriteLine(output);
				counter++;
			}
		}
		
		public static void T1_2() 
		{
			string input = Console.ReadLine();
			
			int amount = GetNum();
			
			string output = "";
			
			int counter = 0;
			
			while (counter < amount) {
				output += input;
				counter++;
			}
			
			counter = 0;
			
			while (counter < amount) {
				Console.WriteLine(output);
				counter++;
			}
		}
	}
}