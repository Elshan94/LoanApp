using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Models
{
    public class LoanModel
    {
        public LoanModel()
        {
            
        }
        public long Id { get; set; }

       
        [Required(ErrorMessage = "This field cannot be empty")]
        [Range(100,5000)]
        public decimal Amount { get; set; }


        [Required(ErrorMessage = "This field cannot be empty")]
        [Range(3, 24)]
        public int LoanPeriod { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public decimal InterestRate { get; set; }


        [Required(ErrorMessage = "This field cannot be empty")]
        public DateTime DayOutPeriod { get; set; }

        public IEnumerable<InvoiceModel> Invoices { get; set; }

        public long ClientId { get; set; }

        public ClientModel Client { get; set; }
    }
}
