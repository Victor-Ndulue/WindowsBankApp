using Models;

namespace Repositories.Interfaces
{
    public interface ITransactionRepository: IGenericRepository<Transaction>
    {
        IEnumerable<Transaction> GetTransactionsByAccountNumber(string accountNumber);
        IEnumerable<Transaction> GetTransactionsByDate(DateTime date);
    }
}
