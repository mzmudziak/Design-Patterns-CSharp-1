using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_zadanie
{
	class OrdersBuilder
	{
		public static void Build(string filename, Customers customers, Orders orders)
		{
			List<string> data = FileReader.read(filename);
			Data processedData = new Data();
			foreach (string s in data)
			{
				string[] strings = s.Split(' ');
				processedData = DataParser.ProcessString(strings);
				if (processedData.dataCorrect)
				{
					// DANE POPRAWNE
					Customer customer = customers.GetCustomer(processedData.name, processedData.surname);
					CustOrders order = orders.getOrderC(customer);
					if (order != null)
					{
						// ZNALEZLISMY CUSTOMERA
						Price price = new Price(processedData.cost, customer.Country.Tax, customer.Country.Currency);
						Item item = new Item(processedData.itemName, price);
						ItemPack itemPack = new ItemPack(item, processedData.itemAmount);
						// SPRAWDZAMY CZY MA DANY ORDER ID
						Order customersOrder = order.getOrderById(processedData.orderId);
						if (customersOrder != null)
						{
							// MA DANY ORDER id, dodajemy mu do zamowienia
							customersOrder.AddElement(itemPack);
						}
						else
						{
							// NIE MA DANEGO ORDERU. ROBIMY NOWY order
							Order neworder = new Order(processedData.orderId);
							neworder.AddElement(itemPack);
							// dodajemy nowy order do listy orderow customera
							order.addNewOrder(neworder);
						}
					}
					else
					{
						// NIE ZNALEZLISMY CUSTOMERA na liscie ORDERSC
						// TWORZYMY NOWEGO ordersc
						CustOrders newOrdersC = new CustOrders(new Order(processedData.orderId), customer);
						orders.Add(newOrdersC);
					}
				}
			}
		}
	}
}