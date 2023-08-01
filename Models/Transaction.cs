using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; } 
        public TransactionType TransactionType { get; set; }
        public string TransactionTypeDescription { set { TransactionType.ToString(); } }
        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
