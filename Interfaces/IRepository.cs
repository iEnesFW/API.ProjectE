using System.Linq.Expressions;

namespace ProjectE.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate); // Dinamik sorgu için
    }
}
