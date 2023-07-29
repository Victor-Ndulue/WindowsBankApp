using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Transaction
    {
        public string Deposit { get; set; }
        public string Withdraw { get; set; }
        public string Transfer { get; set; }
        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
    }
}
