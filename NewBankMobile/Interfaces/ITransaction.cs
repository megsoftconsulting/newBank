using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewBankMobile.Interfaces
{
    public interface ITransaction
    {
        Task<Transaction> Add(Transaction transaction);
        Task<Transaction> Update(Transaction transaction);
        Task<Transaction> GetById(string transactionId);
        Task<IList<Transaction>> ListAllByAccount(string accountId);
        Task<IList<Transaction>> ListAllByOwner(string ownerId);
    }
}

