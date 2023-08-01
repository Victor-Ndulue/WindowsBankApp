using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Account> _accounts;
        public AccountRepository(DataContext context) : base(context)
        {
            _context = context;
            _accounts = _context.Accounts;
        }

        public async Task<Account> GetAccountAsync(string accountNumber)
        {
            Account account= await _accounts.SingleOrDefaultAsync(x=>x.AccountNumber == accountNumber);
            return account;
        } 

        public IQueryable<Account> GetAllAccounts()
        {
            return _accounts.AsQueryable();
        }

        public IEnumerable<Account> GetAccountsByUserId(byte  userId)
        {
            IEnumerable<Account> accounts = _accounts.AsEnumerable().Where(x=>x.UserId == userId);
            return accounts;
        }

        public string GenerateAccountNumber()
        {
            Random random = new Random();
            var number = random.Next(0, 1000000000);
            string AccountNumber = "5" + number.ToString();
            return AccountNumber;
        } 
    }
}
