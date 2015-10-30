using System.Collections.Generic;
using System.Threading.Tasks;
using NewBankMobile.Models;

namespace NewBankMobile.Interfaces
{
    /// <summary>
    /// </summary>
    public interface IAccountRepository
    {
        // Task<Account> Add(Account account);
        //Task<IList<Account>> ListAllByOwner(string ownerId);
        // Task<Account> Update(Account account);
        Task<List<Account>> GetByUserIdAsync(long id);
        Task<Account> GetByIdAsync(long id);
    }
}