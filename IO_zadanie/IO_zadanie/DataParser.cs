using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IO_zadanie
{
	class DataParser
	{
		private class Data
		{
			public string surname;
			public string name;
			public uint orderId;
			public uint itemAmount;
			public string itemName;
			public decimal cost;
		}

		private static Data ProcessString(string[] strings)
		{
			Data data = new Data
			{
				surname = strings[0],
				name = strings[1],
				orderId = uint.Parse(strings[2]),
				itemAmount = uint.Parse(strings[3]),
				itemName = strings[4],
				cost = decimal.Parse(strings[5])
			};
			return data;
		}

		public static void Work(string filename, Customers customers, Orders orders)
		{
			List<string> data = FileReader.read(filename);
			Data processedData = new Data();

			foreach (string s in data)
			{
				string[] strings = s.Split(' ');
				try
				{
					processedData = ProcessString(strings);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);

				}
				Customer customer = customers.GetCustomer(processedData.name, processedData.surname);
				Order order = orders.ById(processedData.orderId);
				Price price = new Price(processedData.cost, customer.Country.Tax, customer.Country.Currency);
				Item item = new Item(processedData.itemName, price);
				ItemPack itemPack = new ItemPack(item, processedData.itemAmount);
				if (order == null)
				{
					order = new Order(processedData.orderId, customer);
				}
				order.AddElement(itemPack);
				orders.Add(order);
			}
		}
	}
}