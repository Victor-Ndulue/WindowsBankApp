using Services.Interfaces;

namespace Services.UnitOfWork.Interfaces
{
    public interface IServiceUnitOfWork
    {
        IUserService UserService { get; }
        IAccountServices AccountService { get; }
        ITransactionServices TransactionService { get; }
    }
}
