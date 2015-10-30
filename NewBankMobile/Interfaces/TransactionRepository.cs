using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace NewBankMobile.Interfaces
{
    public class TransactionRepository : ITransactionRepository
    {
        private static DateTime _seedDate = DateTime.Now;

        private List<Transaction> _transactions = new List<Transaction>
        {
            //Checking Account Transactions
            new Transaction {Id=1,AccountId = 1,Description="On Target",Category="Random Fun",Date = _seedDate.AddHours(-12)},
            new Transaction {Id=2,AccountId = 1,Description="Marshalls",Amount=153.67m,Category="Random Fun", Date = _seedDate.AddHours(-10)},
            new Transaction {Id=3,AccountId = 1,Description="Chipotle Mexican Grill",Amount=23.0m,Category="Restaurant", Date = _seedDate.AddHours(-8)},
            new Transaction {Id=4,AccountId = 1,Description="Payroll",Amount=1500.0m,Category="Megsoft Consulting, Inc", Date = _seedDate.AddHours(-5)},
            new Transaction {Id=5,AccountId = 1,Description="Drinks2Go",Amount=155.70m,Category="Alcohol & Bars", Date = _seedDate.AddHours(-3)},
            new Transaction {Id=6,AccountId = 1,Description="Texaco Gas Station",Amount=205.0m,Category="Fuel", Date = _seedDate.AddHours(-1)},
            new Transaction {Id=7,AccountId = 1,Description="Vimenca",Amount=300.0m,Category="Money Wire", Date = _seedDate.AddHours(-0.5)},
            // Savings Account Transactions
            //  new Transaction {Id=7,AccountId = 1,Description="Vimenca",Amount=300.0m,Category="Money Wire", Date = _seedDate.AddHours(-0.5)},
         
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