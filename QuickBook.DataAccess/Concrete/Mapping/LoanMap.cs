using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.DataAccess.Concrete.Mapping
{
    public class LoanMap : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Amount).IsRequired();

            builder.Property(I => I.LoanPeriod).IsRequired(true);


            builder.HasMany(I => I.Invoices).WithOne(I => I.Loan).HasForeignKey(I => I.LoanId);

        }
    }
}
