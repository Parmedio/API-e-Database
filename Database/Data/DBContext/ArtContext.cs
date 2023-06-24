using Database.Data.Configuration;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Data.DBContext
{
    public class ArtContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<ExhibitionPainting> ExhibitionPainting { get; set; }
        public DbSet<Museum> Museums { get; set; }
        public DbSet<Painting> Paintings { get; set; }

        public ArtContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationAddress());
            modelBuilder.ApplyConfiguration(new ConfigurationArtist());
            modelBuilder.ApplyConfiguration(new ConfigurationExhibition());
            modelBuilder.ApplyConfiguration(new ConfigurationExhibitionPainting());
            modelBuilder.ApplyConfiguration(new ConfigurationMuseum());
            modelBuilder.ApplyConfiguration(new ConfigurationPainting());
            base.OnModelCreating(modelBuilder);
        }
    }
}
