using QuickBook.Api.Services.Abstract;
using QuickBook.DataAccess.Concrete.Context;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Api.Services.Concrete
{
    public class LoanApiService : ILoanApiService
    {
        private readonly LoanContext _context;
        public LoanApiService(LoanContext context) => _context = context;

        public IEnumerable<Invoice> CalculateInvoices(decimal amount, int period, decimal interestRate, DateTime DueDate)
        {
            var obj = _context.Invoices.OrderByDescending(a => a.Id).FirstOrDefault();
            var counter = 1;
            int number = 0;

            if (obj != null)
            {

                string calc = obj.InvoiceNr;





                if (calc.StartsWith("000"))
                {
                    counter = 3;
                    number = Convert.ToInt32(calc.Substring(counter, 1));
                }

                else if (calc.StartsWith("00"))
                {
                    counter = 2;
                    number = Convert.ToInt32(calc.Substring(counter, 2));
                }

                else if (calc.StartsWith("0"))
                {
                    counter = 1;
                    number = Convert.ToInt32(calc.Substring(counter, 3));

                }
                number++;
            }



            List<Invoice> lisr = new List<Invoice>();

            decimal unPaid = 0;
            decimal invoiceAmount = 0;
            if (number == 0)
            {
                number = 1;
            }
            unPaid = ((amount / period) * interestRate) / 100;
            invoiceAmount = amount / period;


            for (int i = 1; i <= period; i++)
            {
                int result = number;
                invoiceAmount += unPaid;
                int zeroCount = number.ToString().Length;
                string val = result.ToString().PadLeft(4, '0');
                number++;



                Invoice invoice = new Invoice();

                invoice.InvoiceNr = val;
                invoice.OrderNr = i;
                invoice.Amount = invoiceAmount;
                invoice.DueDate = DueDate = DueDate.AddMonths(1);

                lisr.Add(invoice);
            }
            return lisr;
        }

        public ServiceResponse<Loan> Create(Loan entity)
        {
            try
            {
                entity.Invoices = CalculateInvoices(entity.Amount, entity.LoanPeriod, entity.MonthlyInterestRate, entity.DayOutPeriod);
                _context.Add(entity);

                _context.SaveChanges();


                return new ServiceResponse<Loan>()
                {
                    Data = entity,
                    Time = DateTime.UtcNow,
                    Message = "Saved",
                    IsSuccess = true
                };

            }
            catch (Exception e)
            {
                return new ServiceResponse<Loan>()
                {
                    Data = entity,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false

                };
            }
        }

        public List<Loan> GetAll()
        {
            return _context.Loans.ToList();
        }

        public Loan GetById(long id)
        {
            return _context.Loans.Find(id);
        }
    }
}
