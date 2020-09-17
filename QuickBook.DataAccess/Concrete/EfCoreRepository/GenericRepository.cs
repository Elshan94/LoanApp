using Microsoft.EntityFrameworkCore;
using QuickBook.DataAccess.Abstract;
using QuickBook.DataAccess.Concrete.Context;
using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.DataAccess.Concrete.EfCoreRepository
{
    public class GenericRepository<TEntity> : IGeneric<TEntity> where TEntity : class, ITable, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using LoanContext context = new LoanContext();

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            using LoanContext context = new LoanContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            using LoanContext context = new LoanContext();
            return await context.FindAsync<TEntity>(id);
        }

       

        public async Task RemoveAsync(TEntity entity)
        {
            using LoanContext context = new LoanContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using LoanContext context = new LoanContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
