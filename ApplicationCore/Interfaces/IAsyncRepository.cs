using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
      //  Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<int> AddAsync(T entity, string sp);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
       // Task<int> CountAsync(ISpecification<T> spec);
    }
}
