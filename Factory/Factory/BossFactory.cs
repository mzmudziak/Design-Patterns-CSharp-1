namespace Zad4___Fabryka
{
	class BossFactory : IFactory
	{
		public Worker GetWorker()
		{
			return new Boss();
		}
	}
}