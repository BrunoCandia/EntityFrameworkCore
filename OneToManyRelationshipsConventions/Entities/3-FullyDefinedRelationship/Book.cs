namespace OneToManyRelationshipsConventions.Entities._3_FullyDefinedRelationship
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
    }
}
