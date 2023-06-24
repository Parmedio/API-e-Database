using Database.Data.DBContext;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Database.Gateway
{
    public class GatewayArtist : IGatewayArtist
    {
        private readonly ArtContext _context;

        public GatewayArtist(ArtContext context)
        {
            _context = context;
        }

        public Artist DeleteArtistById(int id)
        {
            try
            {
                var artist = GetArtistById(id);
                _context.Remove(artist);
                _context.SaveChanges();

                return artist;
            }
            catch
            {
                throw new Exception();
            }
        }

        public Artist GetArtistById(int id)
        {
            return _context.Artists.AsNoTracking().Where(a => a.Id == id).FirstOrDefault();
        }

        public Artist InsertArtist(Artist artist)
        {
            try
            {
                _context.Artists.Add(artist);
                _context.SaveChanges();

                return artist;
            }
            catch
            {
                throw new Exception();
            }
        }

        public Artist UpdateArtist(Artist artistToUpdate)
        {
            try
            {
                _context.Update(artistToUpdate);
                _context.SaveChanges();

                return artistToUpdate;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
