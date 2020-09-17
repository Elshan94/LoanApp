using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.DataAccess.Concrete.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
           
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.FirstName).HasMaxLength(200).IsRequired();

            builder.Property(I => I.LastName).HasMaxLength(200).IsRequired(true);

            builder.HasMany(I => I.Loans).WithOne(I => I.Client).HasForeignKey(I => I.ClientId);

            builder.HasData(new Client { 
            
                Id =1,
            FirstName = "Corrado",
            LastName = "Soprano",
            TelephoneNumber = "1241"
            
            
            },
            new Client
            {
                Id = 2,
                FirstName = "Johhny",
                LastName = "Sack",
                TelephoneNumber = "666"


            },

              new Client
              {
                  Id= 3,
                  FirstName = "Chris",
                  LastName = "Moltisanti",
                  TelephoneNumber = "111"


              });
        }
    }
}
