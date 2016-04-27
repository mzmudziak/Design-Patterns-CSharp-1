using System.Collections.Generic;

namespace Zad2___Dekorator_konkurs
{
					public abstract class ContestDecorator : IContest
					{
						protected IContest DecoratedContest;
						protected List<int> Numbers;

						protected ContestDecorator(IContest decoratedContest, List<int> numbers )
						{
							this.DecoratedContest = decoratedContest;
							this.Numbers = numbers;
						}
						public void Play()
						{
						  DecoratedContest.Play();
						}
					}
}
