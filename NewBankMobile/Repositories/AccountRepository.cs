using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewBankMobile.Models;
using NewBankMobile.Interfaces;

namespace NewBankMobile.Repositories
{
    /// <summary>
    ///     In-Memory implementation of the <see cref="IAccountRepository" /> Interface
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        private readonly List<Account> _accounts = new List<Account>
        {
            new Account
            {
                Id = 1,
                OwnerId = 1,
                Name = "Smart Checking",
                Number = "XXX XXX 007",
                CurrentBalance = 563677.56m,
                AccountType = AccountType.Debit
            },
            new Account
            {
                Id = 2,
                OwnerId = 1,
                Name = "Click Click Savings",
                Number = "XXX XXX 357",
                CurrentBalance = 78953677.00m,
                AccountType = AccountType.Debit
            },
            new Account
            {
                Id = 3,
                OwnerId = 1,
                Name = "Credit Card Click++",
                Number = "XXX XXX 557",
                CurrentBalance = 1323648.42m,
                AccountType = AccountType.Credit
            }

        };

        public Task<List<Account>> GetByUserIdAsync(long id)
        {
            return Task.
                Factory.
                StartNew(() =>
                {
                    return _accounts
                        .Where(c => c.OwnerId == id)
                        .ToList();
                });
        }

        public Task<Account> GetByIdAsync(long id)
        {
            return Task.
                Factory.
                StartNew(() => { return _accounts.SingleOrDefault(c => c.Id == id); });
        }
    }
}