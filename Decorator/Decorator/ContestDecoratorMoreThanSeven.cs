using System;

namespace Decorator
{
	class ContestDecoratorMoreThanSeven : ContestDecorator
	{
		public override void Play()
		{
			DecoratedContest.Play();
			Reward();
		}

		private void Reward()
		{
			if (DecoratedContest.GetNumbers().Count > 7)
			{
				Console.WriteLine("You won 150!");
			}
		}

		public ContestDecoratorMoreThanSeven(IContest decoratedContest) : base(decoratedContest)
		{
		}
	}
}