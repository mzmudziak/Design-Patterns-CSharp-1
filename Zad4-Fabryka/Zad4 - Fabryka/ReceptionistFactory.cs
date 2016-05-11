namespace Zad4___Fabryka
{
	class ReceptionistFactory : IFactory
	{
		public Worker GetWorker()
		{
			return new Receptionist();
		}
	}
}