using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewBankMobile.Models;

namespace NewBankMobile.Interfaces
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
                CurrentBalance = 563677.56m
            },
            new Account
            {
                Id = 2,
                OwnerId = 1,
                Name = "Smart Savings",
                Number = "XXX XXX 357",
                CurrentBalance = 3083677.56m
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
