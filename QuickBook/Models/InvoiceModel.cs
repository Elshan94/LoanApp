using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Models
{
    public class InvoiceModel
    {

        public long Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; }

        public string InvoiceNr { get; set; }

        public int OrderNr { get; set; }

        public long LoanId { get; set; }
        public LoanModel Loan { get; set; }
    }
}
