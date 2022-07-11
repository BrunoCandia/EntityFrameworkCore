namespace OneToOneRelationshipsConventions.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public Biography Biography { get; set; } = null!;
    }
}
