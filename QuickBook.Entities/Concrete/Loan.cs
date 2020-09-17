using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.Entities.Concrete
{
  public  class Loan : ITable
    {

        public long Id { get; set; }

        public decimal Amount { get; set; }

        public decimal MonthlyInterestRate { get; set; }
        public int LoanPeriod { get; set; }

        public DateTime DayOutPeriod { get; set; }

        public IEnumerable<Invoice> Invoices { get; set; }
        public long ClientId { get; set; }

        public Client Client { get; set; }
    }
}
