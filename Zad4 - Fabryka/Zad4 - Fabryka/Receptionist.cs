using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4___Fabryka
{
	class Receptionist : Worker
	{
		public Receptionist()
		{
			for (int i = 0; i <= 40; i++)
			{
				RoomAccess.Add(i);
			}
			RoomAccess.Remove(3);
			RoomAccess.Remove(20);
			RoomAccess.Remove(2);
			RoomAccess.Remove(40);
			RoomAccess.Remove(1);
			RoomAccess.Remove(4);
		}
	}
}