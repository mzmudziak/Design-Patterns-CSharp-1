using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			ITransferable account1 = new Account(1,100);
			ITransferable account2 = new Account(2,100);
			ICommand transferCommand = new TransferCommand(account1,account2);
			account1.getMoneyAmount();
			account2.getMoneyAmount();
			Bank bank = new Bank(transferCommand);
			bank.Transfer(30);
			account1.getMoneyAmount();
			account2.getMoneyAmount();
		}
	}
}
