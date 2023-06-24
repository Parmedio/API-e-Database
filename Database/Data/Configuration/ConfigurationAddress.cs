using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Data.Configuration;

public class ConfigurationAddress : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> entity)
    {
        entity.Property(a => a.Id)
            .UseIdentityColumn();
                
        entity.HasData(
                new Address { Id = 1, Street = "via delle Fornaci", CivicNumber = 2, City = "Pesaro", Country = "Italy" },
                new Address { Id = 2, Street = "via San Sebastiano", CivicNumber = 22, City = "Pistoia", Country = "Italy" },
                new Address { Id = 3, Street = "via del Commercio", CivicNumber = 13, City = "Oviedo", Country = "Spain" },
                new Address { Id = 4, Street = "via Mercatore", CivicNumber = 17, City = "Damasco", Country = "Syria" }
                );
    }
}

