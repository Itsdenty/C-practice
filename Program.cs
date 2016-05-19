/*
 * Created by SharpDevelop.
 * User: Spinach
 * Date: 5/19/2016
 * Time: 6:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Random_dice
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Welcome to the dice choice game!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			int dice;
			int diceAgain;
			int dieNumber;
			Random roller = new Random();
			Console.Write("please choose your favourite dice number!");
			dieNumber= Convert.ToInt32(Console.ReadLine());
			dice= (int)(roller.NextDouble()*dieNumber) + 1;
			diceAgain= (int)(roller.NextDouble()*dieNumber) +1;
			Console.Write("your dice are numbers {0} and {1}", dice, diceAgain);
			Console.ReadLine();
			Console.WriteLine("press enter to quit");
			Console.ReadLine();
		}
	}
}