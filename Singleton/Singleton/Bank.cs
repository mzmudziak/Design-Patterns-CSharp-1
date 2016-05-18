using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Bank // INVOKER
	{
		private ICommand _command;

		public Bank(ICommand command)
		{
			_command = command;
		}

		public void Transfer()
		{
			_command.Execute();
		}
	}
}