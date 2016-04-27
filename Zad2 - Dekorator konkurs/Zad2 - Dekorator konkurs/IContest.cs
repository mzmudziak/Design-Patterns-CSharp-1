using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Zad2___Dekorator_konkurs
{
	public interface IContest
	{
										
		void Play();
		List<int> Numbers { get; set; }
	}
}