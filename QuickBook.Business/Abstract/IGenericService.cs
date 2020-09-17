using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.Business.Abstract
{
 public interface IGenericService<TEntity>  where TEntity : class , ITable , new()
    {


        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> FindByIdAsync(long id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}
