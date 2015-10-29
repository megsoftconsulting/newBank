using System;

namespace NewBankMobile
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public string AffectedAccount { get; set; }
        public DateTime Date { get; set; }

        public Transaction()
        {
        }
    }
}

