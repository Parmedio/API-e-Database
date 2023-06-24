using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Data.Configuration;

public class ConfigurationExhibition : IEntityTypeConfiguration<Exhibition>
{
    public void Configure(EntityTypeBuilder<Exhibition> entity)
    {
        entity.Property(a => a.Id)
            .UseIdentityColumn();

        entity.HasData(
            new Artist { Id = 1, Name = "Gli animali nella pittura del 1900" },
            new Artist { Id = 2, Name = "Le città nel postimpressionismo"},
            new Artist { Id = 3, Name = "Il sacro nel 900"},
            new Artist { Id = 4, Name = "Ritratti di donna nel corso dei secoli"}
            );
    }
}

