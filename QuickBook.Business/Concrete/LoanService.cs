using QuickBook.Business.Abstract;
using QuickBook.DataAccess.Abstract;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickBook.Business.Concrete
{
 public   class LoanService : GenericService<Loan> , ILoanService
    {

        private readonly IGeneric<Loan> _genericRepository;
        private readonly ILoan _loan;
        public LoanService(IGeneric<Loan> genericRepository, ILoan loan) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _loan = loan;
        }

        public Task<IEnumerable<Loan>> GetAllWithClients()
        {
            return _loan.GetAllWithClients();
        }

        public IEnumerable<Invoice> CalculateInvoices(decimal amount, int period, decimal interestRate,  DateTime DueDate)
        {

            return _loan.CalculateInvoices(amount, period, interestRate,  DueDate);
        }

        public Task<Loan> GetByIdWithInvoices(long id)
        {
            return _loan.GetByIdWithInvoices(id);
        }
    }
}
