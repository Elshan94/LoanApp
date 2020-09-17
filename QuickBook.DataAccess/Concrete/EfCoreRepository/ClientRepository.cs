using Microsoft.EntityFrameworkCore;
using QuickBook.DataAccess.Abstract;
using QuickBook.DataAccess.Concrete.Context;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.DataAccess.Concrete.EfCoreRepository
{
   public class ClientRepository : GenericRepository<Client>, IClient
    {

        private readonly LoanContext _context;

        public ClientRepository(LoanContext context) => _context = context;


        public async Task<IEnumerable<Client>> GetAllWithLoans()
        {
            using var context = new LoanContext();

            return await context.Clients.Include(a => a.Loans).ToListAsync();
        }
    }
}
