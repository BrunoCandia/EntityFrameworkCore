namespace ManyToManyRelationshipsFluentApi.Entities._1_IncludeModelForJoinTable
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public Author Author { get; set; } = null!;
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}
