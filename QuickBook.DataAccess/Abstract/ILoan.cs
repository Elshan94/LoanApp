using QuickBook.DataAccess.Concrete.Auxiliary;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.DataAccess.Abstract
{
   public interface ILoan : IGeneric<Loan>
    {
     Task<IEnumerable<Loan>>  GetAllWithClients();

        Task<Loan> GetByIdWithInvoices(long id);
        IEnumerable<Invoice> CalculateInvoices(decimal amount, int period, decimal interestRate, DateTime DueDate);
    }
}
