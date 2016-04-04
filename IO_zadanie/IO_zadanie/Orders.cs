using System;
using System.Collections.Generic;
using System.Linq;

namespace IO_zadanie
{
	internal class Orders
	{
		private List<Order> _ordersList;
		private int _ordersAmount;

		public Orders()
		{
			_ordersList = new List<Order>();
			_ordersAmount = 0;

		}

		public void Add(Order order)
		{
			_ordersList.Add(order);
			_ordersAmount++;
		}

		public void List()
		{
			Console.WriteLine("Total orders: " + _ordersAmount);
			foreach (var order in _ordersList)
			{
					order.OrderInfo();
			}
		}

		public void Pay()
		{
			foreach (var order in _ordersList)
			{
				order.Pay();
			}
		}

		public Order ById(uint id)
		{
			return _ordersList.FirstOrDefault(order => order.Id.Equals(id));
		}
	}
}