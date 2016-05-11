using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zad4___Fabryka
{
	class Worker
	{
		public List<int> RoomAccess = new List<int>();

		public void ListAccess()
		{
			Console.WriteLine(GetType().Name);
			Console.WriteLine("Access:");
			foreach (var i in RoomAccess)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}