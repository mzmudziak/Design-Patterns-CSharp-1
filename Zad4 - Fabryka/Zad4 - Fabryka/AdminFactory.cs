namespace Zad4___Fabryka
{
	class AdminFactory : IFactory
	{
		public Worker GetWorker()
		{
			return new Administrator();
		}
	}
}