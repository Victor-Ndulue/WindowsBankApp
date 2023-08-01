using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<User> _users;    
        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
            _users = _context.Users;
        }

        public async Task<User> GetUserAsync(string email)
        {
            User user = await _users.FindAsync(email);
            return user;
        }

        public IQueryable<User> GetAllUsers() 
        {
            IQueryable<User> users = _users.AsQueryable();
            return users;
        }
    }
}
