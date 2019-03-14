/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 14/03/2019
 * Time: 5:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3T5
{
	class Program
	{
		public static void Main(string[] args)
		{
			while (true) {
				Console.WriteLine("What happens when you throw a yellow rock in the red sea?");
				if (Console.ReadLine() == "It gets wet") {
					break;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}