using Models;

namespace Repositories.Interfaces
{
    public interface IAccountRepository: IGenericRepository<Account>
    {
        IQueryable<Account> GetAllAccounts();
        IEnumerable<Account> GetAccountsByUserId(byte userId);
        Task<Account> GetAccountAsync(string accountNumber);
    }
}
