using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.Entities.Concrete
{
   public class Invoice : ITable
    {

        public long Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; }

        public string InvoiceNr { get; set; }

        public int OrderNr { get; set; }

        public long LoanId { get; set; }
        public Loan Loan { get; set; }
    }
}
