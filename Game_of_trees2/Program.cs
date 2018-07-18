	using System;
						
	public class Program
	{
		public static void Main()
		{
			GameOfThrees(31337);
		}
		
		public static void GameOfThrees(int N)
		{
			while (N > 1)
			{
				int rem = N % 3;
				if (rem != 0)
				{
					rem = (rem == 1 ? -1 : 1);
				}
				
				Console.WriteLine(N + " " + rem);
				N += rem;
				N = N / 3;
			}
			Console.WriteLine(N);
        Console.ReadKey();
		}
	}