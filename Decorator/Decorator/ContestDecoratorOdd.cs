using System;
using System.Linq;

namespace Decorator
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
			return DecoratedContest.GetNumbers().All(number => number%2 != 0);
		}

		public ContestDecoratorOdd(IContest decoratedContest) : base(decoratedContest)
		{
		}
	}
}