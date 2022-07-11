namespace ManyToManyRelationshipsFluentApi.Entities._1_IncludeModelForJoinTable
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}
