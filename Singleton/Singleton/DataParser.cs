using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class DataParser
	{
		public static CommandData ProcessCommands(String[] dataFromFile)
		{
			CommandData commandData = new CommandData();
			try
			{
				commandData.AccountNumberGiver = int.Parse(dataFromFile[0]);
				commandData.AccountNumberReceiver = int.Parse(dataFromFile[1]);
				commandData.TransferAmount = decimal.Parse(dataFromFile[2]);
				Console.WriteLine(commandData.AccountNumberGiver + " " + commandData.AccountNumberReceiver + " " +
				                  commandData.TransferAmount);
			}
			catch (
				Exception exception)
			{
				Console.WriteLine(exception.Message);
				return new CommandData();
			}
			return commandData;
		}

		public static AccountData ProcessAccounts(String[] dataFromFile)
		{
			AccountData data = new AccountData();
			try
			{
				data.AccountId = int.Parse(dataFromFile[0]);

				data.AccountNumber = int.Parse(dataFromFile[1]);
				data.AccountBalance = decimal.Parse(dataFromFile[2]);
				Console.WriteLine(data.AccountId + " " + data.AccountNumber + " " + data.AccountBalance);
			}
			catch (
				Exception exception)
			{
				Console.WriteLine(exception.Message);
				return new AccountData();
			}
			return data;
		}
	}
}