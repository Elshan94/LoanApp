using QuickBook.Business.Abstract;
using QuickBook.DataAccess.Abstract;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.Business.Concrete
{
   public  class InvoiceService : GenericService<Invoice>, IInvoiceService
    {

        private readonly IGeneric<Invoice> _genericRepository;
        public InvoiceService(IGeneric<Invoice> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
