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
			// Private modifier
			private int id;
			private decimal balance;
			// Public modifier
			public int Id;
			public decimal Balance;
						
			public void Deposit(int depositAmount)
			{
				Balance = Balance + depositAmount;
			}

			public void WithDraw(int withdrawAmount)
			{
				Balance = Balance - withdrawAmount;
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
