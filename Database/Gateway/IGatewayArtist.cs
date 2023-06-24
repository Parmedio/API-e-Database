using Database.Models;

namespace Database.Gateway
{
    public interface IGatewayArtist
    {
        public Artist InsertArtist(Artist artist);
        public Artist GetArtistById(int id);
        public Artist UpdateArtist(Artist artist);
        public Artist DeleteArtistById(int id);
    }
}
