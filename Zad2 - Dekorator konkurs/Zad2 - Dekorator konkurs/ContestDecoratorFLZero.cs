using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2___Dekorator_konkurs
{
	class ContestDecoratorFLZero : ContestDecorator
	{
		public override void Play()
		{
			DecoratedContest.Play();
			Reward();
		}

		private void Reward()
		{
			if (DecoratedContest.Numbers.First().Equals(0) && DecoratedContest.Numbers.Last().Equals(0))
			{
				Console.WriteLine("You won 100!");
			}
		}


		public ContestDecoratorFLZero(IContest decoratedContest) : base(decoratedContest)
		{
		}
	}
}