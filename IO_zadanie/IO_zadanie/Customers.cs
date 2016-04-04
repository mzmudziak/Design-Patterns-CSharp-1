using System;
using System.Collections.Generic;

namespace IO_zadanie
{
	internal class Customers
	{
		private List<Customer> CustomersList;

		public void Add(Customer customer)
		{
			CustomersList.Add(customer);
		}

		public Customers()
		{
			CustomersList = new List<Customer>();
		}

		public void ShowList()
		{
			foreach (var currentCustomer in CustomersList)
			{
				Console.WriteLine(currentCustomer.Name + " " + currentCustomer.Surname + " from " + currentCustomer.Country.Name);
			}
		}

		public Customer GetCustomer(string name, string surname)
		{
			foreach (Customer customer in CustomersList)
			{
				if (customer.Name.Equals(name) && customer.Surname.Equals(surname))
				{
					return customer;
				}
			}
			return null;
		}
	}
}