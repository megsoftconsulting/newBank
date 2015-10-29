using System;

namespace NewBankMobile
{
    public class AccountOwner
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateCreated { get; set; }

        public AccountOwner()
        {
        }
    }
}

