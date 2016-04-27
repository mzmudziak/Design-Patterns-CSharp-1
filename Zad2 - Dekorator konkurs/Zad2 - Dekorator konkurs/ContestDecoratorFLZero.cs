using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2___Dekorator_konkurs
{
	class ContestDecoratorFLZero : ContestDecorator
	{
		public void Play()
		{
			DecoratedContest.Play();
			Reward();
		}

		private void Reward()
		{
			if (Numbers.First().Equals(0) && Numbers.Last().Equals(0))
			{
				Console.WriteLine("You won 100!");
			}
		}


		public ContestDecoratorFLZero(IContest decoratedContest) : base(decoratedContest)
		{
		}
	}
}