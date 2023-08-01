namespace Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);
    }
}
