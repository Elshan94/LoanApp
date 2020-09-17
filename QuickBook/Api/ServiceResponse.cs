using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Api
{
    public class ServiceResponse<T>
    {

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public DateTime Time { get; set; }

        public T Data { get; set; }
    }
}
