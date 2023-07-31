using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Account:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public double AccountBalance;
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
