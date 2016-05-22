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
			FileReader.ReadAccounts("C:\\accounts.txt");
			FileReader.ReadCommands("C:\\commands.txt");
			Bank bank1 = new Bank();
			Bank bank2 = new Bank();
			Bank bank3 = new Bank();
			Bank bank4  = new Bank();
			List<Bank> banks = new List<Bank>();
			banks.Add(bank1);
			banks.Add(bank2);
			banks.Add(bank3);
			banks.Add(bank4);
			CommandQueue cq = CommandQueue.GetInstance();
			foreach (var bank in banks)
			{
				bank.GetCommand(cq.GetCommand());
				bank.Transfer();
			}
		}
	}
}