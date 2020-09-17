using QuickBook.Business.Abstract;
using QuickBook.DataAccess.Abstract;
using QuickBook.DataAccess.Concrete.EfCoreRepository;
using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.Business.Concrete
{
   public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {

        private readonly IGeneric<TEntity> _genericRepository;

        public GenericService(IGeneric<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _genericRepository.AddAsync(entity);


        }

        public Task<TEntity> FindByIdAsync(long id)
        {
            return _genericRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await _genericRepository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _genericRepository.UpdateAsync(entity);
        }
    }
}
