using ApplicationCore.Entities;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync(ISpecification<T> specification);
        Task<List<T>> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> CountAsync(ISpecification<T> specification);
        Task<T> FirstAsync(ISpecification<T> specification);
        Task<T?> FirstOrDefaultAsync(ISpecification<T> specification);
    }
}
