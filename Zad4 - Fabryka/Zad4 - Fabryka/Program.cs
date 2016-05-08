using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Zad4___Fabryka
{
	class Program
	{
		static void Main(string[] args)
		{
			IFactory factory;
			Worker worker;
			int factoryChoice = -1;
			ListChoice();

			while (int.TryParse(Console.ReadLine(), out factoryChoice))
			{
				ListChoice();
				switch (factoryChoice)
				{
					case 1:
						factory = new AdminFactory();
						break;
					case 2:
						factory = new BossFactory();
						break;
					case 3:
						factory = new CleanerFactory();
						break;
					case 4:
						factory = new ReceptionistFactory();
						break;
					case 5:
						factory = new GuestFactory();
						break;
					default:
						Console.WriteLine("Wrong choice");
						continue;
				}
				worker = factory.GetWorker();
				worker.ListAccess();
			}
		}

		static void ListChoice()
		{
			string[] factoryWorkerTypes =
			{
				"Admin",
				"Boss",
				"Cleaner",
				"Receptionist",
				"Guest",
			};

			Console.Clear();
			foreach (var factoryWorkerType in factoryWorkerTypes.Select((value, index) => new { index, value }))
			{
				Console.WriteLine(factoryWorkerType.index + 1 + ": " + factoryWorkerType.value);
			}
		}
	}
}