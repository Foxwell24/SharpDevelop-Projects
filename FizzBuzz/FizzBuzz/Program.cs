using System;

namespace FizzBuzz
{
	class Program
	{
		public static void Main(string[] args)
		{
			float real = 0;
			int notReal = 0;
			int count = 0;
			

			while(count <100){
				count = count +1;
				notReal = count;
				real = count;
				
				if(real/3 == notReal/3 & real/5 == notReal/5){
					Console.WriteLine("FizzBuzz");					
				}else if(real/5 == notReal/5){
					Console.WriteLine("Buzz");
				}else if(real/3 == notReal/3){
					Console.WriteLine("Fizz");
				}else{
					Console.WriteLine(count);
				}
			}
			
			Console.ReadKey(true);
		}
	}
}