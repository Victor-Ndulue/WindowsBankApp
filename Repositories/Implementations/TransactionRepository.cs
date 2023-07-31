using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories.Implementations
{
    public class TransactionRepository : GenericRepository<Transaction>
    {
        private readonly DataContext _context;
        private readonly DbSet<Transaction> _transactions;
        public TransactionRepository(DataContext context) : base(context)
        {
            _context = context;
            _transactions = _context.Transactions;
        }

        public 
    }
}
