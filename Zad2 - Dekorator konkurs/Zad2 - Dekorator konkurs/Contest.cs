using System;
using System.Collections.Generic;

namespace Zad2___Dekorator_konkurs
{
	public class Contest : IContest
	{
		public void Play()
		{
			Console.Write("You won nothing :(");
		}

		public List<int> Numbers { get; set; }

		public Contest()
		{
			Numbers = new List<int>();
			AddNumbers();
		}

		public void AddNumbers()
		{
			Console.WriteLine("Type your numbers.\nType \"exit\" to play.");
			while (true)
			{
				var line = Console.ReadLine();
				if (line == null) continue;
				int number;
				bool result = int.TryParse(line, out number);
				if (result)
				{
					Numbers.Add(number);
				}
				else if (line.ToLower() == "play")
				{
					return;
				}
				else
				{
					Console.WriteLine("Invalid command.");
				}
			}
		}
	}
}