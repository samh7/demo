using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 123456789;

        private List<Transaction> allTransactions = new List<Transaction>();


        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("NOT SUFFICIENT AMOUNT TO WITHDRAW");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);


        }
        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote\n");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}\n");
            }
            return report.ToString();
        }
    
    }

}
