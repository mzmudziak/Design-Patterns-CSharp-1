using System;
using System.Collections.Generic;
using System.Linq;

namespace IO_zadanie
{
	internal class Orders
	{
		private List<OrdersC> _ordersList;
		private int _ordersAmount;
	  
		public Orders()
		{
			_ordersList = new List<OrdersC>();
			_ordersAmount = 0;
		}

		public void Add(OrdersC order)
		{
			if (_ordersList.Any(order1 => order1.Order.Id == order.Order.Id))
			{
				return;
			}
			_ordersList.Add(order);
				_ordersAmount++;
		}

		public void List()
		{
			Console.WriteLine("Total orders: " + _ordersAmount);
			foreach (var order in _ordersList)
			{
				order.Info();
			}
		}

		public void Pay()
		{
			foreach (var order in _ordersList)
			{
				order.Pay();
			}
		}

		public OrdersC ById(uint id)
		{
			return _ordersList.FirstOrDefault(order => order.Order.Id.Equals(id));
		}
	}
}