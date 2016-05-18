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


			Bank bank = new Bank();
			bank.TransferAll();

		}
	}
}

