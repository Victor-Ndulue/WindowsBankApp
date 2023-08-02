using Repositories.Implementations;
using Repositories.Interfaces;
using Repositories.UnitOfWork.Interface;

namespace Repositories.UnitOfWork.Implementation
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DataContext _context;
        private IUserRepository _userRepository;
        private IAccountRepository _accountRepository;
        private ITransactionRepository _transactionRepository;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public IUserRepository userRepository => _userRepository ??= new UserRepository(_context);
        public IAccountRepository accountRepository => _accountRepository ??= new AccountRepository(_context);
        public ITransactionRepository transactionRepository => _transactionRepository ??= new TransactionRepository(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
