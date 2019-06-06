/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 21/03/2019
 * Time: 3:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W4 {
	class Program {
		public static void Main(string[] args) {
//			T1_1();
//			T1_2();
//			T3_1();
//			T3_2();
//			T3_3();
			T3_4();
			
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
		
		public static void T1_1() {
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
		
		public static void T1_2() {
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
		
		public static void T3_1() {
			string[] names = new string[5];
			
			int counter = 0;
			
			while (counter < names.Length) {
				names[counter] = Console.ReadLine();
				counter++;
			}
			
			while (counter > 0) {
				counter--;
				Console.WriteLine("Hello " + names[counter]);
			}
		}
		
		public static void T3_2() {
			int[] numbers = new int[]{34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
			
			int counter = 0;
			
			int sum = 0;
			
			while (counter < numbers.Length) {
				sum += numbers[counter];
				counter++;
			}
			
			Console.WriteLine(sum);
		}
		
		public static void T3_3() {
			int[] numbers = new int[5];
			
			int counter = 0;
			
			Console.WriteLine(String.Format("Please give me {0} numbers and I'll check if the last one is unique.", numbers.Length + 1));
			
			while (counter < numbers.Length) {
				numbers[counter] = GetNum();
				counter++;
			}
			
			int testNumber = GetNum();
			
			counter = 0;
			
			bool flag = false;
			
			while (counter < numbers.Length) {
				if (numbers[counter] == testNumber) {
					flag = true;
					break;
				}
				counter++;
			}
			
			if (flag) {
				Console.WriteLine("The last number you entered was entered was not unique.");
			} else {
				Console.WriteLine("Thanks for the unique number at the end there.");
			}
		}
		
		public static void T3_4() {
			int[] numbers = new int[5];
			
			int counter = 0;
			
			Console.WriteLine(String.Format("Please give me {0} numbers and I'll check if the last one is unique.", numbers.Length + 1));
			
			while (counter < numbers.Length) {
				numbers[counter] = GetNum();
				counter++;
			}
			
			int testNumber = GetNum();
			
			counter = 0;
			
			int repeats = 0;
			
			while (counter < numbers.Length) {
				if (numbers[counter] == testNumber) {
					repeats += 1;
				}
				counter++;
			}
			
			if (repeats > 0) {
				Console.WriteLine(String.Format("The last number you entered was entered was not unique. It was found {0} times.", repeats));
			} else {
				Console.WriteLine("Thanks for the unique number at the end there.");
			}
		}
	}
}