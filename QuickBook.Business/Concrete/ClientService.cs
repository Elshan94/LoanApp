using QuickBook.Business.Abstract;
using QuickBook.DataAccess.Abstract;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.Business.Concrete
{
   public class ClientService : GenericService<Client>, IClientService
    {

        private readonly IGeneric<Client> _genericRepository;
        private readonly IClient _client;
        private readonly ILoan _loan;
        public ClientService(IGeneric<Client> genericRepository, IClient client, ILoan loan) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _client = client ;
        }

        public Task<IEnumerable<Client>> GetAllWithLoans()
        {
            return _client.GetAllWithLoans();
        }
    }
}
