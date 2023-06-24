namespace API_e_Database.Dto
{
    public class ArtistDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public ArtistDto()
        {
        }

        public ArtistDto(int? id, string name, int yearOfBirth)
        {
            Id = id;
            Name = name;
            YearOfBirth = yearOfBirth;
        }
    }
}
