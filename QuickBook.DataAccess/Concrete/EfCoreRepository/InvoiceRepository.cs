using QuickBook.DataAccess.Abstract;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.DataAccess.Concrete.EfCoreRepository
{
  public  class InvoiceRepository : GenericRepository<Invoice> , IInvoice
    {
    }
}
