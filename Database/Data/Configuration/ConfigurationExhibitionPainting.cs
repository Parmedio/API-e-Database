using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Data.Configuration;

internal class ConfigurationExhibitionPainting : IEntityTypeConfiguration<ExhibitionPainting>
{
    public void Configure(EntityTypeBuilder<ExhibitionPainting> entity)
    {
        entity.HasKey(ep => new { ep.ExhibitionId, ep.PaintingId });

        entity.HasOne(ep => ep.Exhibition)
            .WithMany(e => e.Paintings)
            .HasForeignKey(ep => ep.ExhibitionId);

        entity.HasOne(ep => ep.Painting)
            .WithMany(p => p.Exhibitions)
            .HasForeignKey(ep => ep.PaintingId);

        entity.HasData(
            new ExhibitionPainting { ExhibitionId = 1, PaintingId = 1 },
            new ExhibitionPainting { ExhibitionId = 1, PaintingId = 2 },
            new ExhibitionPainting { ExhibitionId = 2, PaintingId = 3 },
            new ExhibitionPainting { ExhibitionId = 2, PaintingId = 4 },
            new ExhibitionPainting { ExhibitionId = 3, PaintingId = 5 },
            new ExhibitionPainting { ExhibitionId = 3, PaintingId = 6 },
            new ExhibitionPainting { ExhibitionId = 4, PaintingId = 7 },
            new ExhibitionPainting { ExhibitionId = 4, PaintingId = 8 }
        );
    }
}
