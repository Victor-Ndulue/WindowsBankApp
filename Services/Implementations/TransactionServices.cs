using Models;
using Repositories.UnitOfWork.Interface;
using Services.Interfaces;
using System.Text;

namespace Services.Implementations
{
    internal sealed class TransactionServices:ITransactionServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }     

        public async Task DepositAsync(string accountNumber, double depositAmount)
        {
            Account account = await GetUser(accountNumber);
            account.AccountBalance += depositAmount;
            _unitOfWork.accountRepository.Update(account);
            Transaction transaction = new Transaction
            {
                TransactionDate = DateTime.UtcNow,
                TransactionType = TransactionType.Deposit,
                leftBalance=account.AccountBalance,
                TransactionTypeDescription = "Deposit",
                AccountId = account.Id
            };
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
        }

        public async Task WithdrawAsync(string userAccountNumber, double withdrawAmount)
        {
            Account account = await GetUser(userAccountNumber);
            if (account.AccountBalance >= withdrawAmount)
            {
                account.AccountBalance -= withdrawAmount;
                _unitOfWork.accountRepository.Update(account);
                Transaction transaction = new Transaction
                {
                    TransactionDate = DateTime.UtcNow,
                    TransactionType = TransactionType.Withdraw,
                    leftBalance = account.AccountBalance,
                    TransactionTypeDescription = "Withdraw",
                    AccountId = account.Id
                };
                await _unitOfWork.SaveAsync();
                _unitOfWork.Dispose();
            }
        }

        public async Task TransferAsync(string userAccountNumber, string recipientAccountNumber ,double transferAmount ) 
        {
            Account userAccount = await GetUser(userAccountNumber);
            Account recpient = await _unitOfWork.accountRepository.GetAccountAsync(recipientAccountNumber);
            if (userAccount.AccountBalance >= transferAmount)
            {
                userAccount.AccountBalance -= transferAmount;
                recpient.AccountBalance += transferAmount;
                _unitOfWork.accountRepository.Update(userAccount);
                _unitOfWork.accountRepository.Update(recpient);

                Transaction transaction = new Transaction
                {
                    TransactionDate = DateTime.UtcNow,
                    TransactionType = TransactionType.Transfer,
                    leftBalance = userAccount.AccountBalance,
                    TransactionTypeDescription = "Transfer",
                    AccountId = userAccount.Id
                };
                await _unitOfWork.SaveAsync();
                _unitOfWork.Dispose();
            }
        }


        public string GetTransactionsByAccountAsync(string userAccountNumber)
        {
            var transactions = _unitOfWork.transactionRepository.GetTransactionsByAccountNumber(userAccountNumber).ToList();
            if (transactions.Count == 0)
            {
                return "No transactions found for the account.";
            }

            var stringBuilder = new StringBuilder();
            foreach (var transaction in transactions)
            {
                stringBuilder.AppendLine($"TransactionDate: {transaction.TransactionDate}, Transaction type: {transaction.TransactionTypeDescription}, Balance: {transaction.leftBalance}");
            }

            return stringBuilder.ToString();
        }

        public string GetTransactionsByDate(DateOnly userDate)
        {
            DateTime date = userDate.ToDateTime(TimeOnly.MinValue);
            var transactions = _unitOfWork.transactionRepository.GetTransactionsByDate(date).ToList();
            if (transactions.Count == 0)
            {
                return "No transactions found for the account.";
            }
            var stringBuilder = new StringBuilder();
            foreach (var transaction in transactions)
            {
                stringBuilder.AppendLine($"TransactionDate: {transaction.TransactionDate}, Transaction type: {transaction.TransactionTypeDescription}, Balance: {transaction.leftBalance}");
            }

            return stringBuilder.ToString();
        }

        public async Task<Account> GetUser(string userAccountNumber)
        {
            Account account = await _unitOfWork.accountRepository.GetAccountAsync(userAccountNumber);
            return account;
        }

    }
}
