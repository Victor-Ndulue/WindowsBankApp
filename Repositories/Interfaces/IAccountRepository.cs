using Models;

namespace Repositories.Interfaces
{
    public interface IAccountRepository
    {
        IQueryable<Account> GetAllAccounts();
        IEnumerable<Account> GetAccountsByUserId(byte userId);
        Task<Account> GetAccountAsync(string accountNumber);
    }
}
