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
		private readonly ITransferable _transferReceiver;
		private readonly ITransferable _transferGiver;
		private readonly decimal _moneyGiven;

		public TransferCommand(ITransferable giver, ITransferable receiver, decimal moneyGivenDecimal)
		{
			_transferReceiver = receiver;
			_transferGiver = giver;
			_moneyGiven = moneyGivenDecimal;
		}

		public void Execute()
		{
			_transferGiver.Transfer(_transferReceiver, _moneyGiven);
		}
	}
}