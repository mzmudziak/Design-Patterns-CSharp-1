using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
	class DataParser
	{
		public static Data ProcessString(string[] strings)
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
				data.dataCorrect = true;
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
			return data;
		}
	}
}