namespace Services.Interfaces
{
    public interface ITransactionServices
    {
        Task DepositAsync(string accountNumber, double depositAmount);
        Task WithdrawAsync(string userAccountNumber,double withdrawAmount);
        Task TransferAsync(string userAccountNumber, string recipientAccountNumber, double transferAmount);
        string GetTransactionsByAccountAsync(string userAccountNumber);
        string GetTransactionsByDate(DateOnly userDate);

    }
}
