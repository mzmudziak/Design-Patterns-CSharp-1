using System;

namespace IO_zadanie
{
	class Program
	{
		public static void Main(string[] args)
		{
			Customers customers = new Customers();
			Currency currency = new Currency(1, "PLN");
			Currency ano = new Currency(2, "GBP");
			Country country = new Country(20, "Poland", "PL", currency);
			customers.Add(new Customer("Michal", "Zmudziak", country));
			customers.ShowList();
			Orders orders = new Orders();
			Customer cust = customers.GetCustomer("Michal", "Zmudziak");
			orders.List();
			Console.WriteLine();
			orders.Add(new Order(1, cust));
			orders.List();
			Console.WriteLine();
			Order order = orders.ById(1);
			order.AddElement(new ItemPack(new Item("Lopata", new Price(10, 20, currency)), 10));
			order.AddElement(new ItemPack(new Item("Mlotek", new Price(32, 15, currency)), 12));
			orders.List();
			Console.WriteLine();
			customers.ShowList();
		}
	}
}