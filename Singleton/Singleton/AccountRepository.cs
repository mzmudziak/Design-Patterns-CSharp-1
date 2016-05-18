using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class AccountRepository
	{
		private  static AccountRepository instance;
		private Dictionary<int, Account> accounts;

		private AccountRepository()
		{
			accounts = new Dictionary<int, Account>();
		}

		public static AccountRepository GetInstance()
		{
			if (instance == null)
			{
				instance = new AccountRepository();
				return instance;
			}
			return instance;
		}
		public void AddAccount(int id, int accountNumber, decimal balance)
		{
			accounts.Add(accountNumber, new Account(id, accountNumber, balance));
		}



		public Account GetAccount(int accountNumber)
		{
			Account returnedAccount;
		 accounts.TryGetValue(accountNumber, out returnedAccount);
			return returnedAccount;
		}
	}
}
