using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Api.Services.Abstract
{
   public interface Abstract<T>
    {

        List<T> GetAll();

        T GetById(long id);

        ServiceResponse<T> Create(T entity);
    }
}
