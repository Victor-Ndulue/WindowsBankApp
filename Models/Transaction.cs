using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public string Deposit { get; set; }
        public string Withdraw { get; set; }
        public string Transfer { get; set; }
        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
