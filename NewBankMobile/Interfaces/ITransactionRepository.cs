using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewBankMobile.Interfaces
{
    public interface ITransactionRepository
    {
        //Task<Transaction> AddAsync(Transaction transaction);
        //Task<Transaction> UpdateAsync(Transaction transaction);
        /// Task
        /// <IList
        /// <Transaction>> ListAllByOwnerAsync(long ownerId);
        Task<Transaction> GetByIdAsync(long id);

        Task<List<Transaction>> ListAllByAccountAsync(long accountId);
    }
}