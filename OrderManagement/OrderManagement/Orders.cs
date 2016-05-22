using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
	internal class Orders
	{
		private List<CustOrders> _ordersList;
		private int _ordersAmount;
	  
		public Orders()
		{
			_ordersList = new List<CustOrders>();
			_ordersAmount = 0;
		}

		public void Add(CustOrders order)
		{
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

		public CustOrders getOrderC(Customer customer)
		{
			foreach (var ordersC in _ordersList)
			{
				if (ordersC.Customer.Name == customer.Name && ordersC.Customer.Name == customer.Name)
				{
					return ordersC;
				}
			}
			return null;
		}
	}
}