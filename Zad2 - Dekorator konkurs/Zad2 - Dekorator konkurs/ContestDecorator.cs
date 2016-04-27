using System.Collections.Generic;

namespace Zad2___Dekorator_konkurs
{
	public abstract class ContestDecorator : IContest
	{
		protected IContest DecoratedContest;
		public List<int> Numbers { get; set; }

		protected ContestDecorator(IContest decoratedContest)
		{
			this.DecoratedContest = decoratedContest;
			this.Numbers = decoratedContest.Numbers;
		}

		public virtual void Play()
		{
			DecoratedContest.Play();
		}
	}
}