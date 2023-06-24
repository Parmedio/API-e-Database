namespace Database.Models;

public class Exhibition
{
    public int Id { get; set; }
    public string Name { get; set; }


    public virtual IEnumerable<ExhibitionPainting> Paintings { get; set; }
}
