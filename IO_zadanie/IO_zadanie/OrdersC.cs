using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_zadanie
{
	class OrdersC
	{
		public OrdersC(Order order, Customer customer)
		{
			Order = order;
			Customer = customer;
		}

		public Order Order { get; set; }
		public Customer Customer { get; set; }

		public void Info()
		{
			Console.WriteLine("Customer: " + Customer.Name + " " + Customer.Surname);
			Order.OrderInfo();
		}

		public void Pay()
		{
			if (Order.PaymentStatus == false)
			{
				Console.WriteLine("Paying for order " + Order.Id + ": " +
				                  Order.TotalPrice.Netto + " netto " + Order.TotalPrice.Brutto + " brutto " +
				                  Order.TotalPrice.Currency.Name);
				Order.PaymentStatus = true;
			}
			else
			{
				Console.WriteLine("Order " + Order.Id + " already paid.");
			}
		}
	}
}