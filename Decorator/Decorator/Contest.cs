using System;
using System.Collections.Generic;

namespace Decorator
{
	public class Contest : IContest
	{
		public void Play()
		{
		}

		public List<int> Numbers { get; set; }

		public List<int> GetNumbers()
		{
			return Numbers;
		}

		public Contest()
		{
			Numbers = new List<int>();
			AddNumbers();
		}

		public void AddNumbers()
		{
			Console.WriteLine("Type your numbers.\nType \"play\" to exit.");
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