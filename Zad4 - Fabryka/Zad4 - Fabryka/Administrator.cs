namespace Zad4___Fabryka
{
	class Administrator : Worker
	{
		public Administrator()
		{
			for (var i = 1; i <= 40; i++)
			{
				RoomAccess.Add(i);
				RoomAccess.Remove(20);
			}
		}
	}
}