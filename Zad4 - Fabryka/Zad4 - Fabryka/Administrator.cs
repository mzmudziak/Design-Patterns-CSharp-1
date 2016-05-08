using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4___Fabryka
{
	class Administrator : Worker
	{
		public Administrator()
		{
			for (int i = 0; i <= 40; i++)
			{
				RoomAccess.Add(i);
				RoomAccess.Remove(20);
			}
		}
	}
}
