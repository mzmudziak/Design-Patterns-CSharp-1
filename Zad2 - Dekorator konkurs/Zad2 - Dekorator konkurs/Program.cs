using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zad2___Dekorator_konkurs
{
					class Program
					{
										static void Main(string[] args)
										{
											IContest contest = new ContestDecoratorFLZero(new ContestDecoratorMoreThanSeven(new ContestDecoratorOdd(new Contest())));
											contest.Play();
										}
					}
}
