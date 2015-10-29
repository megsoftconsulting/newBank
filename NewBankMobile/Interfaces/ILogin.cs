using System;
using NewBankMobile.Models;
using System.Threading.Tasks;

namespace NewBankMobile.Interfaces
{
    public interface ILogin
    {
        Task<User> LoginAsync();
    }
}

