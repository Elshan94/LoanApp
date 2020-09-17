using Microsoft.Extensions.DependencyInjection;
using QuickBook.Business.Abstract;
using QuickBook.Business.Concrete;
using QuickBook.DataAccess.Abstract;
using QuickBook.DataAccess.Concrete.EfCoreRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.Business.Resolver
{
 public static   class DependencyResolver
    {

        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGeneric<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IClient, ClientRepository>();

            services.AddTransient<ILoanService, LoanService>();
            services.AddTransient<ILoan, LoanRepository>();

            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IInvoice, InvoiceRepository>();

        }
    }
}
