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
		private static bool dataCorrect;
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
			Data data = new Data();
			try
			{
				data.surname = strings[0];
				data.name = strings[1];
				data.orderId = uint.Parse(strings[2]);
				data.itemAmount = uint.Parse(strings[3]);
				data.itemName = strings[4];
				data.cost = decimal.Parse(strings[5]);
				dataCorrect = true;
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
			return data;
		}

		public static void Work(string filename, Customers customers, Orders orders)
		{
			List<string> data = FileReader.read(filename);
			Data processedData = new Data();
			foreach (string s in data)
			{
				dataCorrect = false;
				string[] strings = s.Split(' ');
				processedData = ProcessString(strings);
				if (dataCorrect)
				{
					Customer customer = customers.GetCustomer(processedData.name, processedData.surname);
					OrdersC order = orders.ById(processedData.orderId);
					Price price = new Price(processedData.cost, customer.Country.Tax, customer.Country.Currency);
					Item item = new Item(processedData.itemName, price);
					ItemPack itemPack = new ItemPack(item, processedData.itemAmount);
					if (order == null)
					{
						order = new OrdersC(new Order(processedData.orderId), customer);
					}
					order.Order.AddElement(itemPack);
					orders.Add(order);
				}
			}
		}
	}
}