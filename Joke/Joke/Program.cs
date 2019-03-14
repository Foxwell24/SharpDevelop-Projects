using System;

namespace Counter
{
	class Program
	{
		public static void Main(string[] args)
		{			
			string Input;
			
			Console.WriteLine("What happens when you throw a yellow rock in the Red Sea?");
			Input = Console.ReadLine();

			for (int i = 0; i < 99; i++)
			{
				
				if (Input == "It gets wet.") {
					
				Console.WriteLine("Good job!");
				i = 100;
				
				}else{
					
				Console.WriteLine("What happens when you throw a yellow rock in the Red Sea?");
				Input = Console.ReadLine();
				
				}
			}

		
			
			Console.ReadKey(true);
		}
	}
}