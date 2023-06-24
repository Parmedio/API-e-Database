namespace Database.Models;

public class ExhibitionPainting
{
    public int ExhibitionId { get; set; }
    public int PaintingId { get; set; }


    public virtual Exhibition Exhibition { get; set; }
    public virtual Painting Painting { get; set; }
}
