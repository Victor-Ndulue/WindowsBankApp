using Models;

namespace Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserAsync(string email);
        IQueryable<User> GetAllUsers();
    }
}
