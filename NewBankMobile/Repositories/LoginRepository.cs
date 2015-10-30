using System;
using NewBankMobile.Interfaces;
using System.Threading.Tasks;
using NewBankMobile.Models;

namespace NewBankMobile
{
    public class LoginRepository : ILoginRepository
    {
        public LoginRepository()
        {
        }

        #region ILoginRepository implementation

        public Task<User> LoginAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

