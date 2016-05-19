/*
 * Created by SharpDevelop.
 * User: Spinach
 * Date: 5/19/2016
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace is_divisible_function
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			int number;
			Console.Write("Welcome, please choose a number");
			number = Convert.ToInt32(Console.ReadLine());
			if (number > 0){
				if (number % 8 == 0){
				Console.WriteLine("The number you chose is divisible by 2, 4 and 8");
				Console.ReadLine();
				}
				else {
				Console.WriteLine("The number you chose is not divisible by 2, 4 and 8");
				Console.ReadLine();
			    }
				}
			else {
				Console.WriteLine("0 or numbers less than 0 not acceptable.");
				Console.ReadLine();
			}
			Console.Write("thank you for running this programme.");
			Console.ReadLine();
		}
	}
}