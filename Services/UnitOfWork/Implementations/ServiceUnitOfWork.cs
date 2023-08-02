using Repositories.UnitOfWork.Interface;
using Services.Implementations;
using Services.Interfaces;
using Services.UnitOfWork.Interfaces;

namespace Services.UnitOfWork.Implementations
{
    public sealed class ServiceUnitOfWork:IServiceUnitOfWork
    {
        private readonly IUnitOfWork _unitOfWork;
        private IUserService _userService;
        private IAccountServices _accountServices;
        private ITransactionServices _transactionServices;

        public ServiceUnitOfWork(IUnitOfWork unitOfWork)
        {  
            _unitOfWork = unitOfWork;
        }
        public IUserService UserService => _userService??= new UserService(_unitOfWork);

        public IAccountServices AccountService => _accountServices??=new AccountServices(_unitOfWork);

        public ITransactionServices TransactionService => _transactionServices??= new TransactionServices(_unitOfWork);
    }
}
