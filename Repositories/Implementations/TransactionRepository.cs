﻿using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Transaction> _transactions;
        public TransactionRepository(DataContext context) : base(context)
        {
            _context = context;
            _transactions = _context.Transactions;
        }

        public IEnumerable<Transaction> GetTransactionsByDate(DateOnly date)
        {
            DateTime dateTime = date.ToDateTime(TimeOnly.MinValue);
            IEnumerable<Transaction> transactions = _transactions.Where(x => x.TransactionDate == dateTime).AsEnumerable();
            return transactions;
        }

        public IEnumerable<Transaction> GetTransactionsByAccountNumber(string accountNumber) 
        {
            IEnumerable<Transaction> transactions = _transactions.Where(x => x.Account.AccountNumber == accountNumber).AsEnumerable();
            return transactions;
        }
    }
}
