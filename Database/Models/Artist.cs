namespace Database.Models;

public class Artist
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public int YearOfBirth { get; set; }


    public virtual IEnumerable<Painting>? Paintings { get; set; }

    public Artist()
    {
    }

    public Artist(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public Artist(int id, string name, int yearOfBirth)
    {
        Id = id;
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}
