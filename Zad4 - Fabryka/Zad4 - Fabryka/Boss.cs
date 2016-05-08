using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4___Fabryka
{
	class Boss : Worker
	{
		public Boss()
		{
			RoomAccess.Add(20);
			RoomAccess.Add(2);
			RoomAccess.Add(40);
			RoomAccess.Add(1);
		}
	}
}