using Models;

namespace Repositories.Interfaces
{
    public interface IUserInterface : IGenericRepository<User>
    {
        Task<User> GetUserAsync(string email);
        IQueryable<User> GetAllUsers();
    }
}
