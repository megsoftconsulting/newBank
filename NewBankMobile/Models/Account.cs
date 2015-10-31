namespace NewBankMobile.Models
{
    public class Account
    {
        public long Id { get; set; }

        public long OwnerId { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public decimal CurrentBalance { get; set; }

        public AccountType AccountType { get; set;}
    }
}