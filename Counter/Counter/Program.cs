using System;

namespace Counter
{
	class Program
	{
		public static void Main(string[] args)
		{			
			string Input;
			
			Console.WriteLine("Guess the magic number!");
			Input = Console.ReadLine();

			for (int i = 0; i < 99; i++)
			{
				
				if (Input == "5") {
					
				Console.WriteLine("Good job!");
				i = 100;
				
				}else{
					
				Console.WriteLine("Guess the magic number!");
				Input = Console.ReadLine();
				
				}
			}

		
			
			Console.ReadKey(true);
		}
	}
}