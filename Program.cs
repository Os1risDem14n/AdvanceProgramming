using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
	class StartUp
	{
		public class BankAccount 
		{
			public int id;
			public decimal balance;
						
			public void Deposit(int zzz)
			{
				balance=balance+zzz;
			}

			public void WithDraw(int zzz)
			{
				balance=balance-zzz;
			}

		}
		static void Main(string[] args)
		{
			BankAccount acc = new BankAccount();
            acc.id = 1;
            acc.balance = 15;
            Console.WriteLine($"Account {acc.id}, balance {acc.balance}");
            acc.Deposit(10);
            Console.WriteLine($"Account {acc.id}, balance {acc.balance}");
            acc.WithDraw(15);
            Console.WriteLine($"Account {acc.id}, balance {acc.balance}");
		}
	}
}
