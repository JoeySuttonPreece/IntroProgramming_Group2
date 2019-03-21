/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 21/03/2019
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3Combo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
//			T1();
			T2();
//			T3();
//			T4();
//			T5();
//			T6();
			
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
		
		public static void T1()
		{
			int counter = 1;
			
			while (counter <= 10) {
				Console.WriteLine(counter);
				counter += 1;
			}
		}
		
		public static void T2()
		{
			int counter = 0;
			
			while (counter <= 10) {
				Console.WriteLine(counter * 2);
				counter += 1;
			}
		}
		
		public static void T3()
		{
			while (true) {
				Console.WriteLine("Guess the magic number. It's somewhere between 1 and 10!!!");
				
				if (GetNum() == 5) {
					break;
				}
			}
		}
		
		public static void T4()
		{
			int num = GetNum();
			
			int counter = 0;
			
			while (counter <= num) {
				Console.WriteLine(counter);
				counter += 1;
			}
		}
		
		public static void T5()
		{
			while (true) {
				Console.WriteLine("What happens when you throw a yellow rock in the red sea?");
				if (Console.ReadLine() == "It gets wet") {
					break;
				}
			}
		}
		
		public static void T6()
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
		}
	}
}