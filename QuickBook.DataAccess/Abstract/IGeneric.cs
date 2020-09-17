using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.DataAccess.Abstract
{
   public interface IGeneric<T> where T : class, ITable , new()
    {
      Task<IEnumerable<T>>  GetAllAsync();

       Task<T> GetByIdAsync(long id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);
    }
}
