using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class TransferCommand : ICommand
	{
		private ITransferable _transferReceiver;
		private ITransferable _transferGiver;

		public TransferCommand(ITransferable receiver, ITransferable giver)
		{
			_transferReceiver = receiver;
			_transferGiver = giver;
		}

		public void Execute(int transferAmount)
		{
			_transferGiver.Transfer(_transferReceiver, transferAmount);
		}
	}
}
