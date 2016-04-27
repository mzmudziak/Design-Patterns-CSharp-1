using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3___Strategia
{
	interface ITax
	{
		int Rate { get; set; }
		int GetTaxRate();
	}
}
