using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Interfaces
{
  public   interface  IGenericRepositoryAsync<T> where T: class
    {
        Task<T> GetByidAsync(int id);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetPagedListAsync(int pageNuber,int pageSize);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(int id); 

    }
}
