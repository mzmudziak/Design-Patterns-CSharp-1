using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Decorator
{
	public interface IContest
	{
		void Play();
		List<int> GetNumbers();
	}
}