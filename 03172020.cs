using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;
        public BankAccount() : this(0, 0)
        {
        }
        public BankAccount(int id) : this(id, 0)
        {
        }
        public BankAccount(decimal balance) : this(0, balance)
        {
        }
        public BankAccount(int id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public int ID
        {

            get { return this.id; }
            set { this.id = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
        }
        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:F2}";
        }
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var inputData = input.Split();

                switch (inputData[0])
                {
                    case "Create":
                        CreateAccount(int.Parse(inputData[1]), accounts);
                        break;
                    case "Deposit":
                        Deposit(int.Parse(inputData[1]), decimal.Parse(inputData[2]), accounts);
                        break;
                    case "Withdraw":
                        Withdraw(int.Parse(inputData[1]), decimal.Parse(inputData[2]), accounts);
                        break;
                    case "Print":
                        Print(int.Parse(inputData[1]), accounts);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void Print(int id, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            Console.WriteLine(accounts[id].ToString());
        }

        private static void Withdraw(int id, decimal amount, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            accounts[id].Withdraw(amount);
        }

        private static void Deposit(int id, decimal amount, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            accounts[id].Deposit(amount);
        }

        private static void CreateAccount(int id, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                return;
            }

            accounts[id] = new BankAccount(id);
        }
    }
}

