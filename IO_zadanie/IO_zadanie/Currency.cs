using System;

namespace IO_zadanie
{
	internal class Currency
	{
		public Currency(float exchangeRate, string name)
		{
			ExchangeRate = exchangeRate;
			Name = name;
		}

		public Currency()
		{
			ExchangeRate = 1;
					Name  = string.Empty;
		}

		public float ExchangeRate { get; set; }

		public string Name { get; set; }
	}
}