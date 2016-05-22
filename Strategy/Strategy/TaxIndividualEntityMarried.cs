using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3___Strategia
{
	class TaxIndividualEntityMarried : ITax
	{
		public int Rate { get; set; }
		public int GetTaxRate()
		{
			throw new NotImplementedException();
		}
	}
}
