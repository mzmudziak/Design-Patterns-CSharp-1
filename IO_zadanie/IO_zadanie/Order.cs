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
				Console.WriteLine("Paying for order " + Id + ", Price: " + TotalPrice.Brutto + "brutto");
			}
			else
			{
				Console.WriteLine("Order " + Id + " already paid.");
			}
		}

		public void OrderInfo()
		{
			Console.WriteLine("ID: " + Id);
			Console.WriteLine("Customer: " + Customer.Name);
			Console.WriteLine("Price: " + TotalPrice.Brutto + " brutto");
			foreach (ItemPack itemPack in ItemPacks)
			{
				Console.WriteLine("     Item name: " +itemPack.Item.Name);
				Console.WriteLine("     Item price: " + itemPack.Item.Price.Brutto + " brutto");
				Console.WriteLine("     Item amount: "+ itemPack.Amount);
				Console.WriteLine("     Pack price: " + itemPack.Price.Brutto + " brutto");
			}
		}
	}
}