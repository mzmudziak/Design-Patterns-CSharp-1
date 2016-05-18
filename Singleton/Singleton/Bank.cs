using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Bank
	{
		private ICommand _transferCommand;

		public void GetCommand(ICommand command)
		{
			if (_transferCommand == null)
			{
				_transferCommand = command;
			}
		}

		public void Transfer()
		{
			if (_transferCommand == null) return;
			_transferCommand.Execute();
			_transferCommand = null;
		}

		public void TransferAll()
		{
			CommandQueue queue = CommandQueue.GetInstance();
			ICommand command;
			while ((command = queue.GetCommand()) != null)
			{
				command.Execute();
			}
		}
	}
}