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
		void getMoneyAmount();
		void addMoney(decimal money);
		Account GetAccount();
	}
}
