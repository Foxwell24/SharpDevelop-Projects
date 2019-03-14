using System;

namespace Count_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int num1 = 0;
			int count = 0;
			string input;
			
			
			Console.WriteLine("Gimmi a Number");
			input = Console.ReadLine();
			num1 = int.Parse(input);
			
			while(count <=num1) {
				Console.WriteLine(count);
				count = count + 1;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}