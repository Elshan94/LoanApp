using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Models
{
    public class ClientModel
    {

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TelephoneNumber { get; set; }

        public IEnumerable<LoanModel> Loans { get; set; }
    }
}
