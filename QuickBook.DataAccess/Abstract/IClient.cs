using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.DataAccess.Abstract
{
   public interface IClient : IGeneric<Client>
    {
        Task<IEnumerable<Client>> GetAllWithLoans();
    }
}
