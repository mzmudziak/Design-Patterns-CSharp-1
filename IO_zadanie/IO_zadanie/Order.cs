using System;
using System.Collections.Generic;
using System.Linq;

namespace IO_zadanie
{
	internal class Order
	{
		public Order(uint id)
		{
			Id = id;
			PaymentStatus = false;
			ItemPacks = new List<ItemPack>();
			TotalPrice = new Price();
		}

		public bool PaymentStatus { get; set; }
		public uint Id { get; set; }
		public List<ItemPack> ItemPacks { get; set; }
		public Price TotalPrice { get; set; }

		public void AddElement(ItemPack itemPack)
		{
			ItemPacks.Add(itemPack);
			TotalPrice.addPrice(itemPack.Price);
		}

		public void Pay()
		{
			if (PaymentStatus == false)
			{
				Console.WriteLine("Paying for order " + Id + ": " +
				                  TotalPrice.Netto + " netto " + TotalPrice.Brutto + " brutto " +
				                  TotalPrice.Currency.Name);
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
			Console.WriteLine("Currency: " + TotalPrice.Currency.Name);
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