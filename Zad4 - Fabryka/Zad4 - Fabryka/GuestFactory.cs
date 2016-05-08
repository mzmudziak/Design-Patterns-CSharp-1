namespace Zad4___Fabryka
{
	class GuestFactory : IFactory
	{
		public Worker GetWorker()
		{
			return new Guest();
		}
	}
}