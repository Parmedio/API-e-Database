namespace Database.Models;

public class Painting
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int YearOfCreation { get; set; }
    public int MuseumId { get; set; }
    public int ArtistId { get; set; }

    
    public virtual Museum Museum { get; set; }
    public virtual Artist Artist { get; set; }
    public virtual IEnumerable<ExhibitionPainting> Exhibitions { get; set; }
}
