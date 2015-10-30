using System;
using System.Threading.Tasks;
using NewBankMobile.Models;

namespace NewBankMobile.Interfaces
{
    public interface ILoginRepository
    {
        Task<User> LoginAsync();
    }

    public class LoginRepository : ILoginRepository
    {
        public Task<User> LoginAsync()
        {
            throw new NotImplementedException();
        }
    }
}