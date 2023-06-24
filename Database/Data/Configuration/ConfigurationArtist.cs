using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Data.Configuration;

public class ConfigurationArtist : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> entity)
    {
        entity.Property(a => a.Id)
            .UseIdentityColumn();

        entity.HasData(
            new Artist { Id = 1, Name = "Bryant", YearOfBirth = 1990 }, 
            new Artist { Id = 2, Name = "Jordan", YearOfBirth = 1990 }, 
            new Artist { Id = 3, Name = "Jokic", YearOfBirth = 1990 },
            new Artist { Id = 4, Name = "Smart", YearOfBirth = 1990 }
            );
    }
}

