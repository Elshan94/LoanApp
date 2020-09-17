using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.Business.Abstract
{
  public  interface IClientService : IGenericService<Client>
    {

        Task<IEnumerable<Client>> GetAllWithLoans();
    }
}
