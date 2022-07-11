namespace OneToManyRelationshipsConventions.Entities._3_FullyDefinedRelationship
{
    public class BookV2
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
    }
}
