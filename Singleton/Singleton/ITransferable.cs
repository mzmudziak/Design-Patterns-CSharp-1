using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	interface ITransferable
	{
		void Transfer(ITransferable receiver, int transferAmount);
		void getMoneyAmount();
		void getMoney(decimal money);
		Account GetAccount();
	}
}
