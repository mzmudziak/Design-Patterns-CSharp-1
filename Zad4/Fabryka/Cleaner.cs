namespace Zad4___Fabryka
{
	class Cleaner : Worker
	{
		public Cleaner()
		{
			for (var i = 1; i <= 40; i++)
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