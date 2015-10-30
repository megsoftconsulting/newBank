using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewBankMobile.Interfaces;

namespace NewBankMobile.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        static DateTime _seedDate = DateTime.Now;

        List<Transaction> _transactions = new List<Transaction>
        {
            //Checking Account Transactions
                new Transaction {Id=1,AccountId = 1,Description="On Target",Category="Debit",Date = _seedDate.AddHours(-12)},
                new Transaction {Id=2,AccountId = 1,Description="Marshalls",Amount=153.67m,Category="Debit", Date = _seedDate.AddHours(-10)},
                new Transaction {Id=3,AccountId = 1,Description="Chipotle Mexican Grill",Amount=23.0m,Category="Debit", Date = _seedDate.AddHours(-8)},
                new Transaction {Id=4,AccountId = 1,Description="Payroll Megsoft",Amount=1500.0m,Category="Credit", Date = _seedDate.AddHours(-5)},
                new Transaction {Id=5,AccountId = 1,Description="Drinks2Go",Amount=155.70m,Category="Debit", Date = _seedDate.AddHours(-3)},
                new Transaction {Id=6,AccountId = 1,Description="Texaco Gas Station",Amount=205.0m,Category="Debit", Date = _seedDate.AddHours(-1)},
            new Transaction {Id=7,AccountId = 1,Description="Vimenca",Amount=300.0m,Category="Debit", Date = _seedDate.AddHours(-0.5)},
            // Savings Account Transactions

                new Transaction {Id=8,AccountId = 2,Description="Online Deposit", Amount=153.67m, Category="Credit",Date = _seedDate.AddHours(-12)},
                new Transaction {Id=9,AccountId = 2,Description="Online Deposit",Amount=153.67m,Category="Credit", Date = _seedDate.AddHours(-10)},
                new Transaction {Id=10,AccountId = 2,Description="Transfere to Account xx55",Amount=155.70m,Category="Debit", Date = _seedDate.AddHours(-3)},
                new Transaction {Id=11,AccountId = 2,Description="Interes generated",Amount=23.0m,Category="Credit", Date = _seedDate.AddHours(-8)},
                new Transaction {Id=12,AccountId = 2,Description="Payroll Click Click",Amount=1500.0m,Category="Credit", Date = _seedDate.AddHours(-5)},
                new Transaction {Id=13,AccountId = 2,Description="Payment Morgate Loan",Amount=155.70m,Category="Debit", Date = _seedDate.AddHours(-3)},

                new Transaction {Id=14,AccountId = 3,Description="Mustang GT",Amount=11500.0m,Category="Debit", Date = _seedDate.AddHours(-5)},
                new Transaction {Id=15,AccountId = 3,Description="Hotel Grand Hyatt Dubai",Amount=155.70m,Category="Debit", Date = _seedDate.AddHours(-3)}

        };

        public Task<Transaction> GetByIdAsync(long id)
        {
            return  Task.Run(()=> _transactions.Single(t => t.Id.Equals(id)));
          
        }

        public Task<List<Transaction>> ListAllByAccountAsync(long accountId)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return _transactions
                    .Where(i => i.AccountId == accountId)
                    .ToList();
            });

            return result;

        }
    }
}