using System;
using System.Collections.Generic;

namespace IO_zadanie
{
	internal class Order
	{
		public Order(uint id, Customer customer)
		{
			Id = id;
			Customer = customer;
			PaymentStatus = false;
			ItemPacks = new List<ItemPack>();
			TotalPrice = new Price();
		}

		public bool PaymentStatus { get; set; }
		public uint Id { get; set; }
		public List<ItemPack> ItemPacks { get; set; }
		public Price TotalPrice { get; set; }
		public Customer Customer { get; set; }

		public string GetPaymentStatus()
		{
			return PaymentStatus ? "Yes" : "No";
		}

		public void AddElement(ItemPack itemPack)
		{
			ItemPacks.Add(itemPack);
			TotalPrice.addPrice(itemPack.Price);
		}

		public void Pay()
		{
			if (PaymentStatus == false)
			{
				Console.WriteLine("Paying for order " + Id + " : " + Customer.Name + " " + Customer.Surname + " : " +
				                  TotalPrice.Netto + " netto " + TotalPrice.Brutto + " brutto " +
				                  Customer.Country.Currency.Name);
				PaymentStatus = true;
			}
			else
			{
				Console.WriteLine("Order " + Id + " already paid.");
			}
		}

		public void OrderInfo()
		{
			Console.WriteLine("Order ID: " + Id);
			Console.WriteLine("Customer: " + Customer.Name + " " + Customer.Surname);
			Console.WriteLine("Currency: " + Customer.Country.Currency.Name);
			Console.WriteLine("Total price: " + TotalPrice.Brutto + " brutto \n");
			foreach (ItemPack itemPack in ItemPacks)
			{
				Console.WriteLine("     Item: " + itemPack.Item.Name);

				Console.WriteLine("     Price: " + itemPack.Item.Price.Netto + " netto " + itemPack.Item.Price.Brutto + " brutto");
				Console.WriteLine("     Amount: " + itemPack.Amount);
				Console.WriteLine("     Total price: " + itemPack.Price.Netto + " netto " + itemPack.Price.Brutto + " brutto\n");
			}
		}
	}
}