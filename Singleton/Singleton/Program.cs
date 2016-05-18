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
			CommandQueue cq = CommandQueue.GetInstance();
			cq.AddCommand(new TransferCommand(account1,account2,50));
			cq.AddCommand(new TransferCommand(account2, account1,30));
			cq.AddCommand(new TransferCommand(account1, account2, 70));
			cq.AddCommand(new TransferCommand(account2, account1, 30));
			cq.AddCommand(new TransferCommand(account2, account2, 100));
			Bank bank = new Bank();
			Bank bank1 = new Bank();
			Bank bank2 = new Bank();
			Bank bank3 = new Bank();
			bank.GetCommand(cq.GetCommand());
			bank.Transfer();
			bank1.GetCommand(cq.GetCommand());
			bank1.Transfer();
			bank2.GetCommand(cq.GetCommand());
			bank2.Transfer();
			bank3.GetCommand(cq.GetCommand());
			bank3.Transfer();
			bank3.GetCommand(cq.GetCommand());
			bank3.Transfer();
		}
	}
}
