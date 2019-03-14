/*
 * Created by SharpDevelop.
 * User: 102568393
 * Date: 14/03/2019
 * Time: 4:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace W3T2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int counter = 0;
			
			while (counter <= 10) {
				Console.WriteLine(counter * 2);
				counter += 1;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}