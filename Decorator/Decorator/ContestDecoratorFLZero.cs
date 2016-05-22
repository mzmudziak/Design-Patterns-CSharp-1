using System;
using System.Linq;

namespace Decorator
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
			if (this.DecoratedContest.GetNumbers().First().Equals(0) && DecoratedContest.GetNumbers().Last().Equals(0))
			{
				Console.WriteLine("You won 100!");
			}
		}


		public ContestDecoratorFLZero(IContest decoratedContest) : base(decoratedContest)
		{
		}
	}
}