using Repositories.Interfaces;

namespace Repositories.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        ITransactionRepository transactionRepository { get; }
        IAccountRepository accountRepository { get; }
        IUserRepository userRepository { get; }
        Task SaveAsync();
        void Dispose();
    }
}
