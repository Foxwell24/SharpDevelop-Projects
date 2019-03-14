using System;

namespace Randoms
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int count = 0;
			int left;
			int numberInput = 0;
			string input;
			Random thisIsRandom = new Random();
			int randomInt = thisIsRandom.Next(1, 1000);
			
			
			while(count <10) {
				
				Console.WriteLine("Guess the secret number!");
				input = Console.ReadLine();
				numberInput = int.Parse(input);
				
				if (numberInput == randomInt) {
					Console.WriteLine("NICE!");
					count = 11;
				}else{
					count = count + 1;
					left = 10 - count;
					Console.WriteLine("you have " + left + " guesses left");
					if(numberInput < randomInt) {
						Console.WriteLine("Guess higher");
					}else if (numberInput > randomInt) {
						Console.WriteLine("Guess lower");
					}
				}				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}