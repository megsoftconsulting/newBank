using System;

namespace NewBankMobile.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public int TypeId { get; set; }

        public int CurrencyId { get; set; }

        public decimal CurrentAmount { get; set; }

        public decimal AmountInTransit { get; set; }

        public int OwnerId { get; set; }

        public Account()
        {
        }
    }
}

