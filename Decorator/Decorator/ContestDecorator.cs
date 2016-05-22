using System.Collections.Generic;

namespace Decorator
{
	public abstract class ContestDecorator : IContest
	{
		protected IContest DecoratedContest;

		protected ContestDecorator(IContest decoratedContest)
		{
			DecoratedContest = decoratedContest;
		}

		public virtual void Play()
		{
			DecoratedContest.Play();
		}

		public List<int> GetNumbers()
		{
			return DecoratedContest.GetNumbers();
		}
	}
}