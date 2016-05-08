using System;
using System.Collections.Generic;

namespace Zad4___Fabryka
{
	class Worker
	{
		public List<int> RoomAccess = new List<int>();

		public void ListAccess()
		{
			Console.WriteLine((this.GetType().ToString()));
			Console.WriteLine("Access:");
			foreach (var i in RoomAccess)
			{
				Console.Write(i + " ");
			}
		}
	}
}