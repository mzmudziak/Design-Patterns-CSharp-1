using System;
using System.Collections.Generic;

namespace Zad2___Dekorator_konkurs
{
	public class Contest : IContest
	{
		public List<int> Numbers;

		public void Play()
		{
			Console.WriteLine("Casino won");
		}

		public void AddNumbers()
		{
			string line = "";
			int number = 101;
			while (!line.Equals("exit"))
			{
			 line = Console.ReadLine();
				number = int.Parse(line);
				Numbers.Add(number);
			}
		}
	}

}