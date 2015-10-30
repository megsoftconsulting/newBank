using System;
using System.Collections.Generic;
using NewBankMobile.Models;
using System.Threading.Tasks;

namespace NewBankMobile.Interfaces
{
    public interface IAccount
    {
        Task<Account> Add(Account account);
        Task<Account> GetById(string Id);
        Task<IList<Account>> ListAllByOwner(string ownerId);
        Task<Account> Update(Account account);
    }
}

