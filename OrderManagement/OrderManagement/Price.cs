using System;

namespace OrderManagement
{
	internal class Price
	{
		public Price(decimal netto, decimal tax, Currency currency)
		{
			Netto = Math.Round((netto/currency.ExchangeRate), 2);
			Brutto = Math.Round(((netto + netto*(tax/100))/currency.ExchangeRate), 2);
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
			Netto = Math.Round((otherPrice.Netto*amount), 2);
			Brutto = Math.Round((otherPrice.Brutto*amount), 2);
			Tax = otherPrice.Tax;
			Currency = otherPrice.Currency;
		}

		public decimal Netto { get; set; }
		public decimal Brutto { get; set; }
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
				Netto += Math.Round((otherPrice.Netto/otherPrice.Currency.ExchangeRate), 2);
				Brutto += Math.Round((otherPrice.Brutto/otherPrice.Currency.ExchangeRate), 2);
			}
			else
			{
				throw new Exception("Currency does not match!!!");
			}
		}
	}
}