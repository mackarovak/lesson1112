using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lesson1112
{
	class Account
	{
		public enum AccountType
		{
			Current,
			Savings
		}
		private int index;
		private Type accountType;
		private double balance;

		static int index1 = 0;

		internal Account()
		{
			index = index1++;
		}

		internal Account(double balance)
		{
			index = index1++;
			this.balance = balance;
		}

		internal Account(Type accountType)
		{
			index = index1++;
			this.accountType = accountType;
		}

		internal Account(Type accountType, double balance) : this(accountType)
		{
			this.balance = balance;
		}

		[Conditional("DEBUGGING")]

		public void DumpToScreen()
        {
			Console.WriteLine("Index: {0}", index);
        }

		public bool Draw(double summa)
		{
			if (summa <= balance)
			{
				balance -= summa;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool Put(double summa)
		{
			if (summa > 0)
			{
				balance += summa;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool MakeTransfer(Account receiver, double summa)
		{
			if (Draw(summa))
			{
				receiver.Put(summa);
				return true;
			}
			else
			{
				return false;
			}
		}
		
	}
}
