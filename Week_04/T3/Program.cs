using System;

namespace T3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int count;
			int count2;
			int userIntInput;
			int ifLoop;
			string name;
			string userInput;
			string space;
			
			count = 0;
			count2 = 0;
			ifLoop = 0;
			name = "x";
			space = " ";
			
			Console.WriteLine("Gimmi number");
			userInput = Console.ReadLine();
			userIntInput = int.Parse(userInput);
			
			while(count < userIntInput) {
				
				if(ifLoop < count) {
					count2 = count;
					
					while(count2 < count) {
						Console.Write(space);
						space = space + " ";
						count2++;
					}
				ifLoop++;
				}
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}