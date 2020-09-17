using Microsoft.EntityFrameworkCore;
using QuickBook.DataAccess.Concrete.Mapping;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QuickBook.DataAccess.Concrete.Context
{
   public class LoanContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=Loan; integrated security = true;");
        }


        public DbSet<Client> Clients { get; set; }

        public DbSet<Loan> Loans { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new LoanMap());
            modelBuilder.ApplyConfiguration(new InvoiceMap());
        }

    }
}
