using System.Transactions;

namespace Models
{
    public class Account:BaseEntity
    {
        public double AccountBalance;
        public decimal AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public User User { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
