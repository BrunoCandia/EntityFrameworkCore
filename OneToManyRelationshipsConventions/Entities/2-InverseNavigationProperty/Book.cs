namespace OneToManyRelationshipsConventions.Entities._2_InverseNavigationProperty
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
