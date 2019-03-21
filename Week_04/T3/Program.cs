using System;

namespace T3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int counter;
			int counter2;
			int userIntInput;
			int space;
			string name;
			string userInput;
						
			counter = 0;
			counter2 = 0;
			space = 0;
			name = "x";
			
			Console.WriteLine("Gimmi a number");
			userInput = Console.ReadLine();
			userIntInput = int.Parse(userInput);
			
			
			while(counter < userIntInput) {
				counter2 = userIntInput - counter;
					
				while(counter2 <= userIntInput) {
					Console.Write(name);
					counter2++;
				}
				counter++;
				space = userIntInput;
				while (space > 0)
				{
					Console.Write(" ");
					space = space - counter;
				}
				Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}