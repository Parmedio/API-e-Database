namespace Database.Models;

public class Museum
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AddressId { get; set; }


    public virtual Address Address { get; set; }
    public virtual IEnumerable<Painting> Paintings { get; set; }
}
