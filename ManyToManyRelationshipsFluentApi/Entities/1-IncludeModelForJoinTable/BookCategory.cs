using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManyToManyRelationshipsFluentApi.Entities._1_IncludeModelForJoinTable
{
    public class BookCategory
    {
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }

    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(i => new { i.BookId, i.CategoryId });

            builder.HasOne(i => i.Book)
                   .WithMany(i => i.BookCategories)
                   .HasForeignKey(i => i.BookId);

            builder.HasOne(i => i.Category)
                   .WithMany(i => i.BookCategories)
                   .HasForeignKey(i => i.CategoryId);
        }
    }
}
