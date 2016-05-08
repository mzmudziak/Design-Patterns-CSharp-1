using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
