using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class FileReader
	{
		public static void ReadCommands(string filename)
		{

			StreamReader sr = new StreamReader(filename);
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				string[] s = line.Split(' ');
				CommandData commandData = DataParser.ProcessCommands(s);
				var commandQueue = CommandQueue.GetInstance();
				var accountRepository = AccountRepository.GetInstance();
				TransferCommand command = new TransferCommand(accountRepository.GetAccount(commandData.AccountNumberGiver), 
																																																		accountRepository.GetAccount(commandData.AccountNumberReceiver),
																																																		commandData.TransferAmount);
				commandQueue.AddCommand(command);
			}
		}

		public static void ReadAccounts(string filename)
		{
			StreamReader sr = new StreamReader(filename);
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				string[] s = line.Split(' ');
				AccountData accountData = DataParser.ProcessAccounts(s);
				var accountRepository = AccountRepository.GetInstance();
				accountRepository.AddAccount(accountData.AccountId, accountData.AccountNumber, accountData.AccountBalance);
			}
		}
	}


}
