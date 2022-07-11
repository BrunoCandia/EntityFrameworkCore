using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OneToOneRelationshipsFluentApi.Entitites
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public Biography Biography { get; set; } = null!;
    }

    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasOne(i => i.Biography)
                   .WithOne(i => i.Author)
                   .HasForeignKey<Biography>(i => i.AuthorRef);
        }
    }
}
