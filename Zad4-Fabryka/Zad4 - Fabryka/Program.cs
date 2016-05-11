using System;
using System.Linq;

namespace Zad4___Fabryka
{
	class Program
	{
		private enum Workers
		{
			Admin = 1,
			Boss = 2,
			Cleaner = 3,
			Receptionist = 4,
			Guest = 5
		};

		private static void Main(string[] args)
		{
			int factoryChoice;

			ListChoice();

			while (int.TryParse(Console.ReadLine(), out factoryChoice))
			{
				ListChoice();
				Workers whichWorker = (Workers) factoryChoice;
				IFactory factory;
				switch (whichWorker)
				{
					case Workers.Admin:
						factory = new AdminFactory();
						break;
					case Workers.Boss:
						factory = new BossFactory();
						break;
					case Workers.Cleaner:
						factory = new CleanerFactory();
						break;
					case Workers.Receptionist:
						factory = new ReceptionistFactory();
						break;
					case Workers.Guest:
						factory = new GuestFactory();
						break;
					default:
						Console.WriteLine("Wrong choice");
						continue;
				}
				var worker = factory.GetWorker();
				worker.ListAccess();
			}
		}

		private static void ListChoice()
		{
			Console.Clear();
			Workers[] workers = (Workers[]) Enum.GetValues(typeof (Workers));
			foreach (var factoryWorkerType in workers)
			{
				Console.WriteLine((int) factoryWorkerType + ": " + factoryWorkerType);
			}
		}
	}
}