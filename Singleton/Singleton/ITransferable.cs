using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	interface ITransferable
	{
		void Transfer(ITransferable receiver, decimal moneyGiven);
		void AddMoney(decimal moneyAmount);
		int GetAccountNumber();
		Account GetAccount();
		decimal GetBalance();
	}
}
