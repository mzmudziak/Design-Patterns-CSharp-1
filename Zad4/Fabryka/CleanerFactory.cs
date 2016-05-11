namespace Zad4___Fabryka
{
	class CleanerFactory : IFactory
	{
		public Worker GetWorker()
		{
			return new Cleaner();
		}
	}
}