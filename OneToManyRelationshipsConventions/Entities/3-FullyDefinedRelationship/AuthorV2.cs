namespace OneToManyRelationshipsConventions.Entities._3_FullyDefinedRelationship
{
    public class AuthorV2
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Book> Books { get; set; } = null!;
    }
}
