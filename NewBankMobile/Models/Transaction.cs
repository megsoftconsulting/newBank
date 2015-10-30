using System;
using Humanizer;

namespace NewBankMobile
{
    public class Transaction
    {
        public long Id { get; set; }
        public long AccountId { get; set; }

        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string HumanDate => Date.Humanize();
        public string Category { get; set; }
    }
}