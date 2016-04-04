using System;

namespace IO_zadanie
{
	internal class Price
	{
		public Price(float netto, float tax, Currency currency)
		{
			Netto = netto;
			Brutto = netto + netto*(tax/100);
			Currency = currency;
		}

		public Price()
		{
			Netto = 0;
			Brutto = 0;
			Currency = new Currency();
		}

		public Price(Price otherPrice, uint amount)
		{
			Netto = otherPrice.Netto*amount;
			Brutto = otherPrice.Brutto*amount;
			Tax = otherPrice.Tax;
			Currency = otherPrice.Currency;
		}

		public float Netto { get; set; }
		public float Brutto { get; set; }
		public float Tax { get; set; }
		public Currency Currency { get; set; }


		public void addPrice(Price otherPrice)
		{
			if (Currency == otherPrice.Currency)
			{
				Netto += otherPrice.Netto;
				Brutto += otherPrice.Brutto;
			}
			else if (Currency.Name.Equals(string.Empty))
			{
				Currency = otherPrice.Currency;
				Netto += otherPrice.Netto;
				Brutto += otherPrice.Brutto;
			}
			else
			{
				throw new Exception("Currency does not match!!!");
			}
		}
	}
}