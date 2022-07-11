
Entity Framework Core One To One Relationships Conventions

Entity Framework Core will create a one to one relationship when both entities involved in the relationship contain a navigation property to the other, 
and the dependent entity includes a foreign key property for the principal entity.
The following example illustrates a one to one relationship between Author and Biography:

public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Biography Biography { get; set; }
}

public class Biography
{
    public int BiographyId { get; set; }
    public string BiographyDescription { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string Nationality { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}

EF Core will generate a unique index on the AuthorId foreign key column in the Biographies table to ensure that only one biography can be associated with any particular author.