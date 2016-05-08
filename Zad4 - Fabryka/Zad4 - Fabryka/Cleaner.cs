using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4___Fabryka
{
	class Cleaner : Worker
	{
		public Cleaner()
		{
			for (int i = 0; i <= 40; i++)
			{
				RoomAccess.Add(i);
			}
			RoomAccess.Remove(20);
			RoomAccess.Remove(2);
			RoomAccess.Remove(40);
			RoomAccess.Remove(1);
		}
	}
}
