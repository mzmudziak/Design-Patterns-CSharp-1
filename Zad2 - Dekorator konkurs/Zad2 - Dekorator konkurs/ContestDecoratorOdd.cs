using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2___Dekorator_konkurs
{
	class ContestDecoratorOdd : ContestDecorator
	{
		public override void Play()
		{
			DecoratedContest.Play();
			Reward();
		}

		private void Reward()
		{
			if (CheckOdd())
			{
				Console.WriteLine("You won 50!");
			}
		}

		private bool CheckOdd()
		{
			return DecoratedContest.Numbers.All(number => number%2 != 0);
		}

		public ContestDecoratorOdd(IContest decoratedContest) : base(decoratedContest)
		{
		}
	}
}