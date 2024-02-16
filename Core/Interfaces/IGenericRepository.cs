using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ToListAsync();
        Task<T> GetEntityWithSpecificationAsync(ISpecification<T> specification);
        Task<IReadOnlyList<T>> ToListAsync(ISpecification<T> specification);
    }
}