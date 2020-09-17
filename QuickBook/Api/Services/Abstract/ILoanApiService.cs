using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Api.Services.Abstract
{
  public  interface ILoanApiService : Abstract<Loan>
    {

        IEnumerable<Invoice> CalculateInvoices(decimal amount, int period, decimal interestRate, DateTime DueDate);
    }
}
