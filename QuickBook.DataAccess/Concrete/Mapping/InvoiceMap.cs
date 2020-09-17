using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.DataAccess.Concrete.Mapping
{
    public class InvoiceMap : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Amount).IsRequired();
            builder.Property(I => I.InvoiceNr).IsRequired();
            builder.Property(I => I.OrderNr).IsRequired();
        }
    }
}
