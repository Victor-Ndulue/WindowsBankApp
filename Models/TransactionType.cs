using System.ComponentModel;

namespace Models
{
    public enum TransactionType
    {
        [Description("Transfer")]Transfer = 1,
        Withdraw,
        Deposit,
        CheckBalance
    }
}
