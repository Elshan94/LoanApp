using AutoMapper;
using QuickBook.Entities.Concrete;
using QuickBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBook.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<LoanModel, Loan>();
            CreateMap<Loan, LoanModel>();

            CreateMap<Client, ClientModel>();
            CreateMap<ClientModel, Client>();

            CreateMap<Invoice, InvoiceModel>();
            CreateMap<InvoiceModel, Invoice>();
        }
       
    }
}
