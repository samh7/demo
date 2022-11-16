using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankBank
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        public string Number { get; }


        private List<Transaction> allTransactions = new List<Transaction>() {};
        private static int accountSeed = 12344579;
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountSeed.ToString();
            accountSeed++;

        }

        public void MakeDeposit(decimal amount, DateTime time, string note)
        {
            var deposit = new Transaction(amount, time, note);

            allTransactions.Add(deposit);
        }
    }
}
