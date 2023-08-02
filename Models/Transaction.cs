using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Transaction:BaseEntity
    {
        public DateTime TransactionDate { get; set; } 
        public TransactionType TransactionType { get; set; }
        public double leftBalance { get; set; }  
        public string TransactionTypeDescription { get; set; }
        [ForeignKey(nameof(Account))]
        public byte AccountId { get; set; }
        public Account Account { get; set; }
    }
}
