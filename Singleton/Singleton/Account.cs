using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Account : ITransferable
	{
		private readonly int _accountNumber;
		private decimal _moneyAmount;
		public Account(int accountNumber, decimal moneyAmount)
		{
			_accountNumber = accountNumber;
			_moneyAmount = moneyAmount;
		}
		public void Transfer(ITransferable receiver, decimal transferAmount)
		{
			if (transferAmount < _moneyAmount)
			{
				_moneyAmount -= transferAmount;
				receiver.addMoney(transferAmount);
			}

			Console.WriteLine("Transferring from " + _accountNumber + " to " + receiver.GetAccount()._accountNumber + " (" + transferAmount + ")");
		}

		public void addMoney(decimal money)
		{
			_moneyAmount += money;
		}
		public void getMoneyAmount()
		{
			Console.WriteLine("I am " + _accountNumber + " and i have " + _moneyAmount);
		}

		public Account GetAccount()
		{
			return this;
		}
	}
}
