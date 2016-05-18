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
			
			Console.WriteLine("Transaction: account " + _accountNumber + " sending " + transferAmount +" to account " + receiver.GetAccountNumber());
			Console.WriteLine("Account " + _accountNumber + " balance:  " + _moneyAmount);
			Console.WriteLine("Account " + receiver.GetAccountNumber() + " balance:  " + receiver.GetBalance());
			if (transferAmount < _moneyAmount)
			{
				_moneyAmount -= transferAmount;
				receiver.AddMoney(transferAmount);
				Console.WriteLine("Account " + _accountNumber + " balance: " + _moneyAmount);
				Console.WriteLine("Account " + receiver.GetAccountNumber() + " balance:  " + receiver.GetBalance());
				Console.WriteLine("Transaction successful\n");
			}
			else
			{
				Console.WriteLine("Transaction unsuccessful\n");
			}

		

		}

		public void AddMoney(decimal money)
		{
			_moneyAmount += money;
			Console.WriteLine("Account " + _accountNumber + " received: " + money);
		}



		public int GetAccountNumber()
		{
			return _accountNumber;
		}

		public decimal GetBalance()
		{
			return _moneyAmount;
		}
	}
}
