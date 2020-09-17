using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.Business.Abstract
{
   public interface ILoanService : IGenericService<Loan>
    {
        Task<IEnumerable<Loan>> GetAllWithClients();

        Task<Loan> GetByIdWithInvoices(long id);

        IEnumerable<Invoice> CalculateInvoices(decimal amount, int period, decimal interestRate,  DateTime DueDate);
    }
}
