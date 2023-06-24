using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Data.Configuration;

internal class ConfigurationPainting : IEntityTypeConfiguration<Painting>
{
    public void Configure(EntityTypeBuilder<Painting> entity)
    {
        entity.Property(a => a.Id)
            .UseIdentityColumn();

        entity.HasData(
            new Painting { Id = 1, Title = "Vita dei campi", YearOfCreation = 1920, MuseumId = 1, ArtistId = 1 },
            new Painting { Id = 2, Title = "Spiaggia Lunare", YearOfCreation = 1921, MuseumId = 3, ArtistId = 1 },
            new Painting { Id = 3, Title = "Montagna di sale", YearOfCreation = 1922, MuseumId = 2, ArtistId = 2 },
            new Painting { Id = 4, Title = "La stella più lontana", YearOfCreation = 1923, MuseumId = 4, ArtistId = 2 },
            new Painting { Id = 5, Title = "L'artiglio di ghiaggio", YearOfCreation = 1924, MuseumId = 1, ArtistId = 3 },
            new Painting { Id = 6, Title = "Lo sguardo della madre", YearOfCreation = 1925, MuseumId = 3, ArtistId = 3 },
            new Painting { Id = 7, Title = "La mano del padre", YearOfCreation = 1926, MuseumId = 2, ArtistId = 4 },
            new Painting { Id = 8, Title = "Velocità", YearOfCreation = 1927, MuseumId = 4, ArtistId = 4 }
            );
    }
}

