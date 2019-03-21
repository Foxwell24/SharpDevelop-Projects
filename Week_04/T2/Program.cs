using System;

namespace T2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int counter;
			int counter2;
			string name;
			string userInput;
			int userIntInput;
			
			counter = 0;
			counter2 = 0;
			name = "x";
			
			Console.WriteLine("GImmi a number");
			userInput = Console.ReadLine();
			userIntInput = int.Parse(userInput);
			
			
			while(counter < userIntInput) {
				counter2 = userIntInput - counter;
					
				while(counter2 <= userIntInput) {
					Console.Write(name);
					counter2++;
				}
				Console.WriteLine();
				
				counter++;				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}