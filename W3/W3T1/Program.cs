/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 14/03/2019
 * Time: 4:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3T1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int counter = 1;
			
			while (counter <= 10) {
				Console.WriteLine(counter);
				counter += 1;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}