namespace Database.Models;

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public int CivicNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }


    public virtual Museum Museum { get; set; }
}
