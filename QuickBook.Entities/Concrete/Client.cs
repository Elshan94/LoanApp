using QuickBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.Entities.Concrete
{
    public class Client : ITable
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TelephoneNumber { get; set; }

        public int Age { get; set; }

        public IEnumerable<Loan> Loans { get; set; }
    }
}
