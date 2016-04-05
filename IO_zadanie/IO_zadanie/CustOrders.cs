using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_zadanie
{
	class CustOrders
	{
		public CustOrders(Order order, Customer customer)
		{
			OrdersList = new List<Order>();
			OrdersList.Add(order);
			Customer = customer;
		}

		public List<Order> OrdersList { get; set; }
		public Customer Customer { get; set; }

		public void Info()
		{
			Console.WriteLine("Customer: " + Customer.Name + " " + Customer.Surname);
			foreach (var order in OrdersList)
			{
				order.OrderInfo();
			}
		}

		public Order getOrderById(uint id)
		{
			foreach (var order in OrdersList)
			{
				if (order.Id == id)
				{
					return order;
				}
			}
			return null;
		}

		public void addNewOrder(Order order)
		{
			OrdersList.Add(order);
		}

		public void Pay()
		{
			foreach (var order in OrdersList)
			{
				order.Pay();
			}
		}

		public Order ById(uint id)
		{
			return OrdersList.FirstOrDefault(order => order.Id.Equals(id));
		}
	}
}