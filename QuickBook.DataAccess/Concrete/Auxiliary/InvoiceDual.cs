using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.DataAccess.Concrete.Auxiliary
{
  public  class InvoiceDual
    {
        
        public int OrderNr { get; set; }

        public string InvoiceNr { get; set; }

        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; }
    }
}
