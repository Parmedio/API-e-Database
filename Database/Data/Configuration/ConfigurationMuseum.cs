using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Data.Configuration;

public class ConfigurationMuseum : IEntityTypeConfiguration<Museum>
{
    public void Configure(EntityTypeBuilder<Museum> entity)
    {
        entity.Property(a => a.Id)
            .UseIdentityColumn();

        entity.HasData(
            new Museum { Id = 1, Name = "Museo dei Fiori", AddressId = 1 },
            new Museum { Id = 2, Name = "Gran Museo della Ragione", AddressId = 3 },
            new Museum { Id = 3, Name = "Museo di Arte Maggiore", AddressId = 4 },
            new Museum { Id = 4, Name = "Il Laboratorio della Mente", AddressId = 2 }
            );
    }
}

