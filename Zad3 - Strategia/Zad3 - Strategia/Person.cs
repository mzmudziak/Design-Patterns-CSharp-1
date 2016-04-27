using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3___Strategia
{
	class Person
	{
		private ITax _tax;

		 ITax Tax
		{
			get
			{
				return _tax;
			}

			set
			{
				_tax = value;
			}
		}
	}
}
