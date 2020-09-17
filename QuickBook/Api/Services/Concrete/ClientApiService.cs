using QuickBook.Api.Services.Abstract;
using QuickBook.DataAccess.Concrete.Context;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Api.Services.Concrete
{
    public class ClientApiService : IClientApiService
    {
        private readonly LoanContext _context;
        public ClientApiService(LoanContext context) => _context = context;
        
        public ServiceResponse<Client> Create(Client entity)
        {
            try
            {
                _context.Add(entity);

                _context.SaveChanges();


                return new ServiceResponse<Client>()
                {
                    Data = entity,
                    Time = DateTime.UtcNow,
                    Message = "Saved",
                    IsSuccess = true
                };

            }
            catch (Exception e)
            {
                return new ServiceResponse<Client>()
                {
                    Data = entity,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false

                };
            }
        }

        public List<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client GetById(long id)
        {
            return _context.Clients.Find(id);
        }
    }
}
